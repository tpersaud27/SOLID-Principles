namespace SOLID_Principles
{
    /// <summary>
    /// The purpose of this class is to process a order
    /// This demonstrate the single responsibility principles, where the sole purpose is to process an order
    /// </summary>
    public class OrderProcessor
    {
        private readonly OrderValidator _orderValidator;
        private readonly OrderSaver _orderSaver;
        private readonly OrderNotificationSender _orderNotificationSender;

        // To ensure we are using the single responsibility principle we inject the dependencies from the other classes
        public OrderProcessor(OrderValidator orderValidator, OrderSaver orderSaver, OrderNotificationSender orderNotificationSender)
        {
            _orderValidator = orderValidator;
            _orderSaver = orderSaver;
            _orderNotificationSender = orderNotificationSender;
        }

        // Note the order process consists of the following
        /// Validating Order
        /// Saving Order
        /// Sending Notification
        //// Each of the classes above will have a single responsibility
        public void OrderProcess()
        {
            _orderValidator.Validate();
            _orderSaver.Save(null);
            _orderNotificationSender.SendNotification();
        }

    }

    /// <summary>
    /// The single responsibility of this class is to validate an order
    /// </summary>
    public class OrderValidator {
        public void Validate() { }
    }
    /// <summary>
    /// The single responsbility of this class is to save and order
    /// </summary>
    public class OrderSaver {
        public void Save(string order) { }
    }
    /// <summary>
    /// The single responsbility of this class is to send a order notification
    /// </summary>
    public class OrderNotificationSender {
        public void SendNotification() { }
    }
}
