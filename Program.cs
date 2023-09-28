using enum_extension_and_pattern_matching;


Move myMove = Move.Paper;
Move otherMove = Move.Rock;

Outcome result = myMove.CheckOutcome(otherMove);
Outcome result2 = otherMove.CheckOutcome(otherMove);

Console.WriteLine(result);
Console.WriteLine(myMove.GetPoints());
Console.WriteLine(otherMove.GetPoints());

