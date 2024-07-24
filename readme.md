# ABAP Cloud fails with polymorphism!!!

## What is polymorphism

Polymorphism in object-oriented programming is the ability of different objects to respond to the same method call in a way that's specific to their own class. It allows methods to be defined in a general way in a base class, but implemented differently in derived classes. This enables a single interface to represent different underlying data types, promoting flexibility and reuse in code design. Polymorphism is commonly achieved through method overriding and interfaces, allowing objects of different types to be treated as instances of the same class through a common interface.

## Example
3 classes:

1. base class (abstract)
protected variable itemtype
protected method init (set itemtype = 'BASE')
constructor (calls init)

2. subclass “first”, inherits from baseclass
redefinition of method init (set itemtype = 'first')
constructor (calls super constructor)

3. subclass “seconds”, same like “first” but init set itemtype = 'second'

In if_oo_adt_classrun~main I create an instance of first and second and both instances have itemtype = 'base'!!!!!!!!!

This is not polymorphism!

Complete project rebuilt in C#, where first.itemtype has the value 'first' and second.itemtype has the value 'second'.

