namespace CodeReview
{
    class LivingBeing
    {
        String name;
        LivingBeing parent;

        // extra ";"
        // should be this.name
        LivingBeing(string name) { name = name; };

        function int NumberOfLimbs() { }
        function int NumberOfDigits() { }

        // needs a base case
        /*
        function LivingBeing RootAncestor() {
            if (parent == null) {
                return this;  // Base case: If there's no parent, return the current instance as the root ancestor
            }
            return parent.RootAncestor();
        }
        */
        // spelling error: should be LivingBeing not LivingBegin
        function LivingBegin RootAncestor() {
            return parent.RootAncestor();
        }

        // return float
        // function float DigitsPerLimb() { return (float) NumberOfDigits() / NumberOfLimbs(); }
        function DigitsPerLimb() { return NumberOfDigits / NumberOfLimbs(); }
    }

    // should be PascalCase: class Human
	class human inherits LivingBeing
    {
        /*
        A constructor is needed and can call the superclass
        Example in python:

        class LivingBeing:
            def __init__(self, name):
                self.name = name

        class Human(LivingBeing):
            def __init__(self, name):
                super().__init__(name)

        */
        // function should be small case: function
        // 4 is a string and should be an int
        Function override int NumberOfLimbs() { return “4” }

        // syntax error "[". should be "{"
        function int NumberOfDigits() [ return 10; }
    }

    class JellyFish inherits LivingBeing
    {
        function override int NumberOfLimbs() { return 0 }
        // syntax error "[". should be "{"
        function int NumberOfDigits() [ return 0; }
    }

	function main() {
	    // john in double quotes "John"
	    // LivingBeing john = new Human( "John" };
		LivingBeing john = new Human( John };
		// initialize jane and tom.
		// LivingBeing jane = new Human( "jane" };
		// LivingBeing tom = new Human( "tom" };
		john.parent = jane;
		jane.parent = tom;


		LivingBeing root = john.RootAncestor();
		Console.writeline(john.name + “’s oldest ancestor is “ + root.name) // should be Tom

		// name should be small case
        Console.WriteLine(“Tom’s parent is “ + tom.parent.Name;)


        JellyFish jelly = new JellyFish( “Jelly” );

        // should be float x = jelly.DigitsPerLimb()
        int x = jelly.digitsPerLimb(jelly);
    }
}
