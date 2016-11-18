lines = tuple(open('k2.txt', 'r'))
x = 0
y = 0
p = 0
for l in lines:
    coords = l.split(" ")
    x = 0
    for c in coords:
        z = c
        print("v %s %s %s" % (x-1, y-1, z) )
        print("v %s %s %s" % (x+1, y-1, z) )
        print("v %s %s %s" % (x+1, y+1, z) )
        print("v %s %s %s" % (x-1, y+1, z) )
        print("f %s %s %s %s" % (p, p+1, p+2, p+3))
        p+=4
        x += 1000/512
    y += 1000/424
