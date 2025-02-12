using Car_Rental_Backend_Application.Controllers;
using Car_Rental_Backend_Application.Data.Entities;
using Car_Rental_Backend_Application.Data.RequestDto_s;
using Car_Rental_Backend_Application.Data.ResponseDto_s;
using System;
using System.Linq;

namespace Car_Rental_Backend_Application.Data.Converters
{
    public static class BookingConverters
    {
        private static readonly CarRentalContext _context;
        public static BookingResponseDto BookingToBookingResponseDto(Booking booking)
        {
            
            if (booking == null)
                throw new ArgumentNullException(nameof(booking));

            return new BookingResponseDto
            {
                BookingId = booking.BookingId,
                User_ID = booking.User_ID,
                UserName = booking.User?.Username,
                Email = booking.User?.Email,
                Car_ID = booking.Car_ID,
                CarDetails = $"{booking.Car?.Brand} {booking.Car?.Model}",
                BookingDate = booking.BookingDate,
                PickupDate = booking.PickupDate,
                ReturnDate = booking.ReturnDate,
                TotalPrice = booking.TotalPrice,
                //CancellationIds = booking.Cancellations?.Select(c => c.Cancellation_ID).ToList() ?? new List<int>()
            };
        }

       
        public static Booking BookingRequestDtoToBooking(BookingRequestDto bookingRequestDto)
        {
            if (bookingRequestDto == null)
                throw new ArgumentNullException(nameof(bookingRequestDto));

            return new Booking
            {
                User_ID = bookingRequestDto.User_ID,
                Car_ID = bookingRequestDto.Car_ID,
                BookingDate = bookingRequestDto.BookingDate,
                PickupDate = bookingRequestDto.PickupDate,
                ReturnDate = bookingRequestDto.ReturnDate,
             
            };
        }
    }
}
