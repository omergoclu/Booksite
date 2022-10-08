using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using booksite.business.Abstract;
using booksite.entity;
using booksite.webui.Extensions;
using booksite.webui.Identity;
using booksite.webui.Models;
using Iyzipay;
using Iyzipay.Model;
using Iyzipay.Request;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace booksite.webui.Controllers
{
    [Authorize]
    public class CartController:Controller
    {
        ICartService _cartService;
        IOrderService _orderService;
        private UserManager<User> _userManager;
        public CartController(ICartService cartService,
        UserManager<User> userManager,IOrderService orderService)
        {
            _cartService = cartService;
            _userManager = userManager;
            _orderService = orderService;
        }
        public IActionResult Index()
        {
            var cart = _cartService.GetCartByUserId(_userManager.GetUserId(User));
            return View(new CartModel(){
                CartId = cart.Id,
                CartItems = cart.CartItems.Select(i=>new CartItemModel()
                {
                    CartItemId = i.Id,
                    BookId = i.BookId,
                    Name = i.Book.Name,
                    Price = (double)i.Book.Price,
                    ImageUrl = i.Book.ImageUrl,
                    Quantity = i.Quantity

                }).ToList()
            });
        }
        
        [HttpPost]
        public IActionResult AddToCart(int bookId, int quantity)
        {
            var userId = _userManager.GetUserId(User);
            _cartService.AddToCart(userId,bookId,quantity);
            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult DeleteFromCart(int bookId)
        {
            var userId = _userManager.GetUserId(User);
            _cartService.DeleteFromCart(userId,bookId);
            return RedirectToAction("Index");
        }
        public IActionResult Checkout()
        {
            var cart = _cartService.GetCartByUserId(_userManager.GetUserId(User));
            
            var orderModel = new OrderModel();
            
            orderModel.CartModel = new CartModel(){
                CartId = cart.Id,
                CartItems = cart.CartItems.Select(i=>new CartItemModel()
                {
                    CartItemId = i.Id,
                    BookId = i.BookId,
                    Name = i.Book.Name,
                    Price = (double)i.Book.Price,
                    ImageUrl = i.Book.ImageUrl,
                    Quantity = i.Quantity

                }).ToList()
            };  
            return View(orderModel);
        }
        [HttpPost]
        public IActionResult Checkout(OrderModel model)
        {
            var userId = _userManager.GetUserId(User);
            var cart = _cartService.GetCartByUserId(userId);

            model.CartModel = new CartModel(){
                CartId = cart.Id,
                CartItems = cart.CartItems.Select(i=>new CartItemModel()
                {
                    CartItemId = i.Id,
                    BookId = i.BookId,
                    Name = i.Book.Name,
                    Price = (double)i.Book.Price,
                    ImageUrl = i.Book.ImageUrl,
                    Quantity = i.Quantity

                }).ToList()
            };  
            var payment = PaymentProcess(model); 

            if(ModelState.IsValid)
            {
                if(payment.Status=="success")
                {
                    SaveOrder(model,payment,userId);
                    ClearCart(model.CartModel.CartId);
                    var msg = new AlertMessage()
                    {
                        Message = $"Your order has been created.",
                        AlertType = "success",
                    };
                    TempData["message"] = JsonConvert.SerializeObject(msg);
                    return View("Success");
                }
                else
                {
                    var msg = new AlertMessage()
                    {
                        Message = $"{payment.ErrorMessage}",
                        AlertType = "danger",
                    };
                    TempData["message"] = JsonConvert.SerializeObject(msg);
                }
            }
            return View(model);
        }
        public IActionResult GetOrders()
        {
            var userId = _userManager.GetUserId(User);
            var orders = _orderService.GetOrders(userId);

            var orderListModel = new List<OrderListModel>();
            OrderListModel orderModel ;
            foreach (var order in orders)
            {
                orderModel = new OrderListModel();

                orderModel.OrderId = order.Id;
                orderModel.OrderNumber = order.OrderNumber;
                orderModel.OrderDate = order.OrderDate;
                orderModel.Phone =order.Phone;
                orderModel.FirstName = order.FirstName;
                orderModel.LastName = order.LastName;
                orderModel.Email = order.Email;
                orderModel.Address = order.Address;
                orderModel.City = order.City;
                orderModel.OrderState = order.OrderState;
                orderModel.PaymentType = order.PaymentType;

                orderModel.OrderItems = order.OrderItems.Select(i=>new OrderItemModel(){
                        OrderItemId = i.Id,
                        Name = i.Book.Name,
                        Price = (double)i.Price,
                        Quantity = i.Quantity,
                        ImageUrl=i.Book.ImageUrl,
                }).ToList();

                orderListModel.Add(orderModel);
            }
            return View("Orders",orderListModel);
        }

        public IActionResult GetByAdminOrders()
        {
            var userId = _userManager.GetUserId(User);
            var orders = _orderService.GetOrders(null);

            var orderListModel = new List<OrderListModel>();
            OrderListModel orderModel ;
            foreach (var order in orders)
            {
                orderModel = new OrderListModel();

                orderModel.OrderId = order.Id;
                orderModel.OrderNumber = order.OrderNumber;
                orderModel.OrderDate = order.OrderDate;
                orderModel.Phone =order.Phone;
                orderModel.FirstName = order.FirstName;
                orderModel.LastName = order.LastName;
                orderModel.Email = order.Email;
                orderModel.Address = order.Address;
                orderModel.City = order.City;
                orderModel.OrderState = order.OrderState;
                orderModel.PaymentType = order.PaymentType;

                orderModel.OrderItems = order.OrderItems.Select(i=>new OrderItemModel(){
                        OrderItemId = i.Id,
                        Name = i.Book.Name,
                        Price = (double)i.Price,
                        Quantity = i.Quantity,
                        ImageUrl=i.Book.ImageUrl,
                }).ToList();

                orderListModel.Add(orderModel);
            }

            
            return View("AdminOrders",orderListModel);
        }
        private void ClearCart(int cartId)
        {
            _cartService.ClearCart(cartId);
        }

        private void SaveOrder(OrderModel model, Payment paymnet, string userId)
        {
            var order = new Order();
            order.OrderNumber = new Random().Next(111111,999999).ToString();
            order.OrderState = EnumOrderState.completed;
            order.PaymentType = EnumPaymentType.CreditCard;
            order.PaymentId = paymnet.PaymentId;
            order.ConversationId = paymnet.ConversationId;
            order.OrderDate = new DateTime();
            order.FirstName = model.FirstName;
            order.LastName = model.LastName;
            order.UserId = userId;
            order.Address = model.Address;
            order.Phone = model.Phone;
            order.Email = model.Email;
            order.City = model.City;
            order.Note = model.Note;

            order.OrderItems = new List<entity.OrderItem>();

            foreach (var item in model.CartModel.CartItems)
            {
                var orderItem = new booksite.entity.OrderItem()
                {
                    Price = item.Price,
                    Quantity = item.Quantity,
                    BookId = item.BookId,
                };
                order.OrderItems.Add(orderItem);
            }
            _orderService.Create(order);
        }
        private Payment PaymentProcess(OrderModel model)
        {
            Options options = new Options();
            options.ApiKey = "sandbox-Uft2hJP3j25L1Beva388IeEvGNbdEljD";
            options.SecretKey = "sandbox-SqQeLPDcBWBrO4N4qmYqPKWNUS0jL2Ou";
            options.BaseUrl = "https://sandbox-api.iyzipay.com";
                    
            CreatePaymentRequest request = new CreatePaymentRequest();
            request.Locale = Locale.TR.ToString();
            request.ConversationId = new Random().Next(111111111,999999999).ToString();
            request.Price = model.CartModel.TotalPrice().ToString();
            request.PaidPrice = model.CartModel.TotalPrice().ToString();
            request.Currency = Currency.TRY.ToString();
            request.Installment = 1;
            request.BasketId = "B67832";
            request.PaymentChannel = PaymentChannel.WEB.ToString();
            request.PaymentGroup = PaymentGroup.PRODUCT.ToString();

            PaymentCard paymentCard = new PaymentCard();
            paymentCard.CardHolderName = model.CardName;
            paymentCard.CardNumber = model.CardNumber;
            paymentCard.ExpireMonth = model.ExpirationMonth;
            paymentCard.ExpireYear = model.ExpirationYear;
            paymentCard.Cvc = model.Cvc;
            paymentCard.RegisterCard = 0;
            request.PaymentCard = paymentCard;

            // paymentCard.CardHolderName = model.CardName;
            // paymentCard.CardNumber = "5528790000000008";
            // paymentCard.ExpireMonth = "12";
            // paymentCard.ExpireYear = "2030";
            // paymentCard.Cvc = "123";

            Buyer buyer = new Buyer();
            buyer.Id = "BY789";
            buyer.Name = model.FirstName;
            buyer.Surname = model.LastName;
            buyer.GsmNumber = model.Phone;
            buyer.Email = model.Email;
            buyer.IdentityNumber = "74300864791";
            buyer.LastLoginDate = "2015-10-05 12:43:35";
            buyer.RegistrationDate = "2013-04-21 15:12:09";
            buyer.RegistrationAddress = "Nidakule Göztepe, Merdivenköy Mah. Bora Sok. No:1";
            buyer.Ip = "85.34.78.112";
            buyer.City = model.City;
            buyer.Country = "Turkey";
            buyer.ZipCode = "34732";
            request.Buyer = buyer;

            Address shippingAddress = new Address();
            shippingAddress.ContactName = "Jane Doe";
            shippingAddress.City = "Istanbul";
            shippingAddress.Country = "Turkey";
            shippingAddress.Description = "Nidakule Göztepe, Merdivenköy Mah. Bora Sok. No:1";
            shippingAddress.ZipCode = "34742";
            request.ShippingAddress = shippingAddress;

            Address billingAddress = new Address();
            billingAddress.ContactName = "Jane Doe";
            billingAddress.City = "Istanbul";
            billingAddress.Country = "Turkey";
            billingAddress.Description = "Nidakule Göztepe, Merdivenköy Mah. Bora Sok. No:1";
            billingAddress.ZipCode = "34742";
            request.BillingAddress = billingAddress;

            List<BasketItem> basketItems = new List<BasketItem>();
            BasketItem basketItem;
            foreach (var item in model.CartModel.CartItems)
            {
                basketItem = new BasketItem();
                basketItem.Id = item.BookId.ToString();
                basketItem.Name = item.Name;
                basketItem.Category1 ="Book";
                basketItem.Price = (item.Price * item.Quantity).ToString();
                basketItem.ItemType = BasketItemType.PHYSICAL.ToString();
                basketItems.Add(basketItem);
            }
            request.BasketItems = basketItems;

            return Payment.Create(request, options);
        }
    }
}