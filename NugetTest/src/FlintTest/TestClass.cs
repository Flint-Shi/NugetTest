using System;

namespace FlintTest
{
    public class TestClass
    {
        public const int TotalChanelNumber = 12;
        public const int LysisMotorNumber = TotalChanelNumber;

        public const int TipDropMagnetNumber = 2;

        public const int MaxMppcGainValue = 5000;
        public const int MppcChannelNumber = 4;

        public const ushort FunLowestSpeed = 5000;
        public const ushort FunHighestSpeed = 40000;
        public const ushort FunShutDownCommand = 0xffff;

        public const int PcrChannelNumber = TotalChanelNumber;
        public const int PcrSlotNumber = 4;
        public const int PcrTubeLocationNumber = PcrChannelNumber * PcrSlotNumber;
        public const ushort MaxPcrPwmValue = 40000;
        public const ushort MaxPcrTemperature = 15000;
        public const ushort ClosePcrPwm = 0xffff;

        public const ushort GeneralReleaseCommand = 0xffff;

        public const ushort MaxMiscTemperature = 15000;

        public const int LedNumber = 4;

        public const int AD7606Number = 3;

        public const int NaExtractionHeaterNumber = 3;

        public const byte HotCapHeaterNumber = 2;

        public const int MaxMixUpRounds = 4;
        public const int MaxMixUpRoundsInPos3 = 4;
        public const int MaxMixUpRoundsInPos4 = 8;
        public const int MaxMixUpRoundsInPos5 = 6;
        public const int MaxMixUpRoundsInTe1_1 = 15;
        public const int MaxMixUpRoundsInTe1_2 = 8;
        public const int MaxMixUpRoundsInNo3 = 15;

        public const int MaxMixUpTimesInPos1 = 4;

        public const int MessageDefaultTimeout = 0;
        public const int MessageNormalTimeOut = 5000;
        public const int MessageMotorZarrayTimeout = 15000;
        public const int MessageMotorYplatformTimeout = 15000;
        public const int MessageMotorZarrayPistonTimeout = 20000;

        public const double TimeoutFactorOfResponse = 3.5;
    }
}
