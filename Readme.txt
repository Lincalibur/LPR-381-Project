The format of the input data has to be in the following format

Objective,2,3,4   <-- Objective function coefficients (e.g., z = 2x1 + 3x2 + 4x3)
<=,5,6,7,10     <-- First constraint (e.g., 5x1 + 6x2 + 7x3 <= 10)
>=,1,2,3,4      <-- Second constraint (e.g., x1 + 2x2 + 3x3 >= 4)
==,3,4,5,8      <-- Third constraint (e.g., 3x1 + 4x2 + 5x3 == 8)

and in a text file so the program can use the values.

and

the output text file will be in the format

Objective Function Value: 23.5
Variable Values:
x1: 0.0
x2: 1.5
x3: 1.0
