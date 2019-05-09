namespace MCSereneTest.Northwind {
    export enum OrderShippingState {
        NotShipped = 0,
        Shipped = 1
    }
    Serenity.Decorators.registerEnumType(OrderShippingState, 'MCSereneTest.Northwind.OrderShippingState', 'Northwind.OrderShippingState');
}

