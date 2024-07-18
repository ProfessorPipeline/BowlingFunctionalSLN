# BowlingFunctionalSLN
Porting Haskell bowling calculator by Ron Jeffries to C#

Source: [Haskell Bowling](https://ronjeffries.com/xprog/articles/dbchaskellbowling/)

```haskell
score ([]) = 0
score (x:[]) = x 
score (x:y:[]) = x + y 
score (x:y:z:[]) = x + y + z
score (x:y:z:xs) = if  (x == 10)             then x + y + z +  score(y:z:xs) 
                   else if (((x + y) == 10)) then x + y + z +  score(z:xs)
                   else x + y + score(z:xs)
```

## Features
- Convert a string of bowling throws into a list of integers.

- Calculate the total score from a string or list of bowling throws.

- Functional approach with a focus on immutability and recursion.

