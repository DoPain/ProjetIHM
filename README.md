#Projet IHM

##Questions
1. Il y a une fa�on de gagner : avoir le Graal, et il y a deux fa�ons de pedre : Mordred, et qyuand il n'y a plus assez d'argent. La victoire et la d�faites sont d�clench�es dans la fonction NextTurn de la classe WorldState.

2. Elle renvoie la commande � executer lorsqu'une commande inconnue est envoy�e par l'utilisateur.

3. Non, il n'est pas possible de choisir une difficult�, elle est automatiquement en facile. Ca ne serait pas difficile, il suffirait de demander � l'utilisateur d'entrer la difficult� dans la fonction Main de la classe Program juste avant d'appeler le constructeur de WorldState.

4. Nombre d'objets par classes :
Program       : 0
WorldState    : 1
FunLibrary    : 0
GameControler : 0
IndexedValue  : *

Multiplicit�s :
**TODO**		

5. Si les valeurs ne sont plus utilis�es � partir d'un moment cela pose un probl�me de m�moire car elles ne pourront pas �tre supprim�es, sinon �a n'est pas un gros probl�me car ce ne sont que des r�f�rences.