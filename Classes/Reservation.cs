namespace PrimeiroProjeto.Classes
{
    internal class Reservation
    {
        public int RoomNumber { get; set; }
        public DateTime CheckIn { get; set; }
        public DateTime CheckOut { get; set; }

        public Reservation() { }

        public Reservation(int roomNumber, DateTime checkIn, DateTime checkOut)
        {
            RoomNumber = roomNumber;
            CheckIn = checkIn;
            CheckOut = checkOut;
        }

        public int Duration()
        {
            TimeSpan duration = CheckOut.Subtract(CheckIn);
            return (int)duration.TotalDays;
        }

        public string UpdateDates(DateTime checkIn, DateTime checkOut)
        {
            DateTime now = DateTime.Now;

            if (checkIn < now || checkOut < now)
            {
                return "Data de reserva não podem ser do passado!";
            }

            if (checkOut <= checkIn)
            {
                return "A data de check-out não pode ser menor que a data de check-in";
            }

            CheckIn = checkIn;
            CheckOut = checkOut;
            return null;
        }

        public override string ToString()
        {
            return "Room: " + RoomNumber + ", check-in: " + CheckIn.ToString("dd/MM/yyyy") +
                ", check-out: " + CheckOut.ToString("dd/MM/yyyy") + "duration: " + Duration() + " nights.";
        }
    }
}
