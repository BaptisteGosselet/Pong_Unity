# PONG avec UNITY

<img src="https://unity3d.com/files/images/ogimg.jpg">

## Les contrôles
- Les touches de la barre gauche : **Z** et **S** 
- Les touches de la barre droite : **↑** et **↓** 

## Les classes
### Ball.cs

- Start() : fonction de base de Unity qui est appelée au lancement du jeu
- Reset() : Replace la balle au milieu
- Launch() : Fait le lancé de ball dans une direction aléatoire

### Paddle.cs

- Start() : initialise la position
- Update() : fonction de base de Unity qui est appelée à chaque frame, permet le déplacement des barres
- Reset() : replace la barre dans sa position de départ (après avoir marqué un point)
  
### Goal.cs

- OnTriggerEnter2D(Collider2D collision) : fonction de base de Unity appelée lorsqu'il y a une collision avec cet objet, permet de faire savoir au jeu qu'un point a été marqué

### GameManager.cs

- Player1Scored() et Player2Scored() : ajoute un point au joueur ayant marqué le point
- ResetPosition() : remet à leurs places initiales la ball et les barres