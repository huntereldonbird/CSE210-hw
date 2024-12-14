namespace FinalProject;
using System.Text.Json;
using System.Text.Json.Serialization;

public class TicketSaveFormat {


    public TicketSaveFormat(Ticket[] tickets) {
        _tickets = tickets;
    }
    
    [JsonConstructor]
    public TicketSaveFormat() {

    }

    private Ticket[] _tickets {get; set;}

    public Ticket[] Get() {
        return _tickets;
    }

    public void Set(Ticket[] tickets) {
        _tickets = tickets;
    }
}