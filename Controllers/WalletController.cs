[ApiController]
[Route("wallets")]
public class WalletController : ControllerBase
{
    private readonly WalletService _walletService;

    public WalletController(WalletService walletService)
    {
        _walletService = walletService;
    }

    [HttpPost("{id}/add-funds")]
    public IActionResult AddFunds(string id, [FromBody] decimal amount)
    {
        var wallet = _walletService.AddFunds(id, amount);
        return Ok(wallet);
    }
}
