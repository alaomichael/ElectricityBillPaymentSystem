[ApiController]
[Route("electricity")]
public class ElectricityController : ControllerBase
{
    private readonly BillService _billService;

    public ElectricityController(BillService billService)
    {
        _billService = billService;
    }

    [HttpPost("verify")]
    public IActionResult CreateBill([FromBody] decimal amount)
    {
        var bill = _billService.CreateBill(amount);
        return Ok(bill);
    }

    [HttpPost("Vend/{validationRef}/pay")]
    public IActionResult PayBill(string validationRef, [FromBody] string walletId)
    {
        // Implement bill payment logic here
        return Ok();
    }
}
