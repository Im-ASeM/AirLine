public interface ITicket
{
    public void NewTicket(NewTicket newFly);
    public bool ReturnTicket(int Sit);
    public List<SimpleTicket> SoldTickets();
    public List<SimpleTicket> ReturnedTickets();
    public List<SimpleTicket> AllTickets();
    public List<SitOnly> ShowSits();
    public decimal Amount();
}