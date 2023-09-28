using enum_extension_and_pattern_matching;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace enum_extension_and_pattern_matching
{
    public enum Move
    {
        Rock,
        Paper,
        Scissor
    }
}

public static class MoveExtension
{
    public static Outcome CheckOutcome(this Move self, Move other)
    {
        switch (self)
        {
            case Move.Rock:
                switch (other)
                {
                    case Move.Rock: return Outcome.Draw;
                    case Move.Paper: return Outcome.Win;
                    case Move.Scissor: return Outcome.Loss;
                }

                break;

            case Move.Paper:
                switch (other)
                {
                    case Move.Rock: return Outcome.Win;
                    case Move.Scissor: return Outcome.Loss;
                    case Move.Paper: return Outcome.Draw;
                }

                break;

            case Move.Scissor:
                switch (other)
                {
                    case Move.Rock: return Outcome.Loss;
                    case Move.Paper: return Outcome.Win;
                    case Move.Scissor: return Outcome.Draw;
                }

                break;
        }

        throw new InvalidDataException();

    }

    public static int GetPoints(this Move self)
    {
        switch (self)
        {
            case Move.Rock: return 1;
            case Move.Paper: return 2;
            case Move.Scissor: return 3;
        }
        throw new Exception();
    }
    public static int NewGetPoints(this Move self) =>
        self switch
        {
            Move.Rock => 1,
            Move.Paper => 2,
            Move.Scissor => 3,
            _ => throw new Exception()
        };

    public static int OffsetPoints (this Move self, int offset)
    {
        return self.NewGetPoints() + offset;
    }
    public static Outcome NewCheckOutcome(this Move self, Move other) =>
        (self, other) switch 
        {

            (Move.Rock, Move.Rock) => Outcome.Draw,
            (Move.Rock, Move.Paper) => Outcome.Loss,
            (Move.Rock, Move.Scissor) => Outcome.Win,
            (Move.Paper, Move.Paper) => Outcome.Draw,
            (Move.Paper, Move.Rock) => Outcome.Win,
            (Move.Paper, Move.Scissor) => Outcome.Loss,
            (Move.Scissor, Move.Paper) => Outcome.Win,
            (Move.Scissor, Move.Rock) => Outcome.Loss,
            (Move.Scissor, Move.Scissor) => Outcome.Draw,

            _ => throw new Exception()

        };

}

