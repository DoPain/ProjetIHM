#Projet IHM

##Questions
1. Il y a une façon de gagner : avoir le Graal, et il y a deux façons de pedre : Mordred, et qyuand il n'y a plus assez d'argent. La victoire et la défaites sont déclenchées dans la fonction NextTurn de la classe WorldState.

2. Elle renvoie la commande à executer lorsqu'une commande inconnue est envoyée par l'utilisateur.

3. Non, il n'est pas possible de choisir une difficulté, elle est automatiquement en facile. Ca ne serait pas difficile, il suffirait de demander à l'utilisateur d'entrer la difficulté dans la fonction Main de la classe Program juste avant d'appeler le constructeur de WorldState.

4. Nombre d'objets par classes :
Program       : 0
WorldState    : 1
FunLibrary    : 0
GameControler : 0
IndexedValue  : *

Multiplicités :
**TODO**		

5. Si les valeurs ne sont plus utilisées à partir d'un moment cela pose un problème de mémoire car elles ne pourront pas être supprimées, sinon ça n'est pas un gros problème car ce ne sont que des références.