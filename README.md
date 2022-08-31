# RTS-Take-Home

Write a class in the language of your choice that contains the following two public methods:

## aboveBelow
  - Accepts two arguments
    - An unsorted collection of integers (the list)
    - An integer (the comparison value)
  - Returns a hash/object/map/etc. with the keys "above" and "below" with the corresponding count of integers from the list that are above or below the comparison value

**Example usage**:

*input*: `[1, 5, 2, 1, 10]`, `6`

*output*: `{ "above": 1, "below": 4 }`

## stringRotation
  - Accepts two arguments
    - A string (the original string)
    - A positive integer (the rotation amount)
  - Returns a new string, rotating the characters in the original string to the right by the rotation amount and have the overflow appear at the beginning

**Example usage**:

*input*: `"MyString"`, `2`

*output*: `"ngMyStri"`
