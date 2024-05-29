
public class RTicketProcces : ITicket
{
    Context db = new Context();
    public decimal Amount()
    {
        decimal result = 0;
        foreach (Tickets item in db.tbl_Tickets.ToList())
        {
            if(item.isReturned == false){
                result += item.Price;
            }
        }
        return result;
    }

    public void NewTicket(NewTicket newFly)
    {
        Tickets result = new Tickets{
            FullName = newFly.FullName,
            Origin = newFly.Origin,
            Destination = newFly.Destination,
            FlyTime = DateTime.Now,
            Price = newFly.Price,
            PlainModel = newFly.PlainModel,
            isReturned = false
        };
        db.tbl_Tickets.Add(result);
        db.SaveChanges();
    }

    public List<SimpleTicket> ReturnedTickets()
    {
        List<SimpleTicket> results = new List<SimpleTicket>();
        foreach(Tickets item in db.tbl_Tickets.ToList()){
            if(item.isReturned==true){
                results.Add(ticketToSimple(item));
            }
        }
        return results;
    }

    public bool ReturnTicket(int Sit)
    {
        Tickets chose = db.tbl_Tickets.Find(Sit);
        if(chose==null){
            return false;
        }else{
            chose.isReturned=true;
            db.tbl_Tickets.Update(chose);
            db.SaveChanges();
            return true;
        }
    }

    public List<SimpleTicket> SoldTickets()
    {
        List<SimpleTicket> results = new List<SimpleTicket>();
        foreach (Tickets item in db.tbl_Tickets.ToList())
        {
            if(item.isReturned==false){
                results.Add(ticketToSimple(item));
            }
        }
        return results;
    }
    public List<SimpleTicket> AllTickets(){
        List<SimpleTicket> results = new List<SimpleTicket>();
        foreach (Tickets item in db.tbl_Tickets.ToList())
        {
            results.Add(ticketToSimple(item));
        }
        return results;
    }
    public List<SitOnly> ShowSits(){
        List<SitOnly> results = new List<SitOnly>();
        foreach (Tickets item in db.tbl_Tickets.ToList())
        {
            if(!item.isReturned){
                results.Add(ticketToSit(item));
            }
        }
        return results;
    }
    private SimpleTicket ticketToSimple(Tickets item){
        return new SimpleTicket{
            FullName=item.FullName,
            Origin=item.Origin,
            Destination=item.Destination,
            Price=item.Price,
            FlyTime=item.FlyTime,
            PlainModel=item.PlainModel,
        };
    }
    private SitOnly ticketToSit(Tickets item){
        SitOnly result = new SitOnly{
            Sit = item.Sit,
            FullName = item.FullName,
            Origin = item.Origin,
            Destination = item.Destination
        };
        return result;
    }
}