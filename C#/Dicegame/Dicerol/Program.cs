/* you'll use the Random.Next() method to simulate rolling 
three six-sided dice. You'll evaluate the rolled values to 
calculate the score. If the score is greater than an arbitrary total, 
then you'll display a winning message to the user.
 If the score is below the cutoff, 
you'll display a losing message to the user. */

Random dice = new Random();

int roll1 = dice.Next(1, 7);
int roll2 = dice.Next(1, 7);
int roll3 = dice.Next(1, 7);

int total = roll1 + roll2 + roll3;

Console.WriteLine($"Dice roll: {roll1} + {roll2} + {roll3} = {total}");

if ((roll1 == roll2) || (roll2 == roll3) || (roll1 == roll3))
{
    Console.WriteLine("You rolled doubles! +2 bonus to total!");
    total += 2;
}
if ((roll1 == roll2) && (roll2 == roll3)) 
{
    Console.WriteLine("You rolled triples! +6 bonus to total!");
    total += 6;
}

if (total >= 15) {
    Console.WriteLine("You win!");
}
if (total <15){
    Console.WriteLine("You Loose!");
}

