using System.Data;
using System.Data.Common;
using Microsoft.AspNetCore.Mvc;
[Route("[Action]")]
[ApiController]
public class TicketControllers:Controller
{
    private readonly ITicket db;
    public TicketControllers(ITicket _db)
    {
        db=_db;
    }

    [HttpPost]
    public IActionResult NewTicket(NewTicket ticket){
        db.NewTicket(ticket);
        return Ok($"{ticket.FullName} Added !");
    }
    [HttpPut]
    public IActionResult ReturnTicket(int Sit){
        bool result = db.ReturnTicket(Sit);
        if(result){
            return Ok();
        }else{
            return NotFound();
        }
    }
    [HttpGet]
    public IActionResult SoldTickets(){
        return Ok(db.SoldTickets());
    }
    [HttpGet]
    public IActionResult ReturnedTickets(){
        return Ok(db.ReturnedTickets());
    }
    [HttpGet]
    public IActionResult AllTickets(){
        return Ok(db.AllTickets());
    }
    [HttpGet]
    public IActionResult ShowSits(){
        return Ok(db.ShowSits());
    }
    [HttpGet]
    public IActionResult Amount(){
        return Ok(db.Amount());
    }
}