using System;
using System.Collections.Generic;
using System.Text;

namespace Structures01t02
{
    public struct TrainStruct : IComparable<TrainStruct>
    {
        public readonly int _trainNumber;
        public readonly string _dst;
        public readonly DateTime _date;

        public TrainStruct(int trainNumber, string dst, DateTime date)
        {
            _trainNumber = trainNumber;
            _dst = dst;
            _date = date;
        }

        public void ShowInfo()
        {
            Console.WriteLine($"Train number {_trainNumber}\nDestination {_dst}\n{_date}");
        }

        public int CompareTo(TrainStruct other)
        {
            var trainNumberComparison = _trainNumber.CompareTo(other._trainNumber);
            if (trainNumberComparison != 0) return trainNumberComparison;
            var dstComparison = string.Compare(_dst, other._dst, StringComparison.Ordinal);
            if (dstComparison != 0) return dstComparison;
            return _date.CompareTo(other._date);
        }
    }
}
