# Asterisk Tower Kata

Excercise: https://github.com/AndiPexton/Asterisk.Kata/blob/main/Asterisk%20Tower%20Kata.pdf

Example Youtube - see after attempting exercise

## Initial Thoughts

- function expected to string[] TowerFrom(int heightInRows)

- thought on example logic

1 - >   '*'             --middle nochange\

2 - >   ' * '           --one space then astrick
        '***'           --0 space then 3 astricks\

3->     '  *  '         --two space then astrick
        ' *** '         --one space then astricks -> potentially recusive, unitl one middle
        '*****'         --0 space, then 5 astriks

Bottom number going up by odd values 1, 3, 5...

Code:
- Start with bottom, work out value
- Go up 1, single whitespace each side i.e. -2
- repeat until get to 1



