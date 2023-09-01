// See https://aka.ms/new-console-template for more information

using Head_First_Design_Patterns.Strategy_Pattern;
using Head_First_Design_Patterns.Strategy_Pattern.ActionAdventureGame.Behaviour;
using Head_First_Design_Patterns.Strategy_Pattern.ActionAdventureGame.Client;
using Head_First_Design_Patterns.Strategy_Pattern.After;

Duck mallard = new MallardDuck();
mallard.performQuack();
mallard.performFly();

Duck model = new ModelDuck();
model.performFly();
model.setFlyBehaviour(new FlyRocketPowered());
model.performFly();

Person person = new Person();
person.performQuack();


King king = new King();
king.setWeapon(new SwordBehaviour());
king.fight();

Troll troll = new Troll();
troll.setWeapon(new AxeBehaviour());
troll.fight();

Knight knight = new Knight();
knight.setWeapon(new KnifeBehaviour());
knight.fight();

Queen queen = new Queen();
queen.setWeapon(new BowAndArrowBehaviour());
queen.fight();