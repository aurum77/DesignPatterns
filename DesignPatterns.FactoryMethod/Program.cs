using DesignPatterns.FactoryMethod.Abstract;
using DesignPatterns.FactoryMethod.Conrete;

// It provides a way to delegate the instantiation logic to child classes.
var devManager = new DevelopmentManager();
devManager.TakeInterview(); // asking about design patterns

var marketingManager = new MarketingManager();
marketingManager.TakeInterview(); // asking about community building
