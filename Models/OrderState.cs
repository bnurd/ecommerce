namespace ecommerce.Models;

public enum OrderState
{
    Waiting = 1,
    Accepted,
    Prepare,
    Cargo,
    Delivered
}