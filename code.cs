namespace CodeReview
{
    class LivingBeing
    {
        String name;
        LivingBeing parent;

        LivingBeing(string name) { name = name; };

        function int NumberOfLimbs() { }
        function int NumberOfDigits() { }
        function LivingBegin RootAncestor() {
            return parent.RootAncestor();
        }

        function DigitsPerLimb() { return NumberOfDigits / NumberOfLimbs(); }
    }

	class human inherits LivingBeing
    {
        Function override int NumberOfLimbs() { return “4” }
        function int NumberOfDigits() [ return 10; }
    }

    class JellyFish inherits LivingBeing
    {
        function override int NumberOfLimbs() { return 0 }
        function int NumberOfDigits() [ return 0; }
    }

	function main() {
		LivingBeing john = new Human( John };
		john.parent = jane;
		jane.parent = tom;

		LivingBeing root = john.RootAncestor();
		Console.writeline(john.name + “’s oldest ancestor is “ + root.name) // should be Tom
        Console.WriteLine(“Tom’s parent is “ + tom.parent.Name;)

        JellyFish jelly = new JellyFish( “Jelly” );
        int x = jelly.digitsPerLimb(jelly);
    }
}
