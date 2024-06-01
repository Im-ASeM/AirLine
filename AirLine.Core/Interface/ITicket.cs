public interface ITicket
{
    public void NewTicket(NewTicket newFly);
    public bool ReturnTicket(int Sit); // مرجوع کردن تیکت
    public List<SimpleTicket> SoldTickets(); // تیکت برگشت نخورده
    public List<SimpleTicket> ReturnedTickets(); // تیکت های برگشت خورده
    public List<SimpleTicket> AllTickets(); // همه
    public List<SitOnly> ShowSits(); // ID
    public decimal Amount(); // هزینه ها
}