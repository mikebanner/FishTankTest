# Approach
I used a TDD approach to drive out the solution, starting with a simple scenario whereby the tank was empty and returned 0 as the weight of feed requiredl

I then built out the functionality of a single Goldfish which would take a weight configured within the class constructor (not parameterised) with a method to retrieve the feed weight required for that specific instance of fish. 

I then worked on making the solution more generic by introducting an interface for the fish type with common capabilities of retrieving the name an the feed weight of the fish.

The remaining fish types were built out using the interface, using a TDD approach to ensure each step was still covered.

## Considerations

As you may see in the commit history, I did toy with the idea of passing the feed weight as a parameter into each fish instance. However, I retracted this thought as I believe it was a YAGNI issue that bled outside of the scope of the solution required. If this was to become a requirement further down the line, I would likely introduce some kind of factory or builder class for creating fish with differing feed weights and names to abstract the creation away.

I also consciously decided to use composition over inheritance in this solution. Inheritance would have worked just as well and would have reduced some of the repeated logic around weights and naming, so this is a potential optimisation if reducing code is a concern. Although the fish classes aren't being directly composed of anything else, if I had more time I would have possibly introduced another domain object for managing the feed weight rather than using a simple scalar value on the instance itself. Again this is a YAGNI thing, but had the requirement come out in the future to be able to specify the type of food (e.g. aquarium vs tropical food) then the introduction of a specific domain object to encapsulate this would make sense. 