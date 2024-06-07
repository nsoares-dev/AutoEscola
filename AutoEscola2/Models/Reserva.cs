using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace AutoEscola2.Models
{
    public class Reserva
    {
        public int ReservaId { get; set; }
        public int ClienteId { get; set; }
        public int CarroId { get; set; }
        [DisplayName("Reservado para")]
        public Cliente? Reservador { get; set; } // nome do ser 
        [DisplayName("Carro Reservado")]
        public Carro? CarroReservado { get; set; } // carro reservado 
        [DisplayName("Data da Reserva")]
        [DataType(DataType.DateTime)]
        public DateTime DataReserva { get; set; }
        public Carro? Reservado { get; set; }
    }
}
