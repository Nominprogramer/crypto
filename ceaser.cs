alphabets="abcdefghijklmnopqrstuvwxyz"
strin=input("txt:  ")
key=int(input("key:  "))
n=len(strin)
strout=''

for i in range(n):
	ch=strin[i]
	loc=alphabets.find(ch)
	newloc=(loc+key) %26
	strout+=alphabets[newloc]
print(strout)
