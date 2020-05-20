match=[]
count=maxi=0
topthree=[" "," "," "," "," "]
#********************************************************************************************************************************************************************************************************************
def Topscorer():
    print("\n\n\n")
    gdata = open(r'd:\a\nameteam.txt', 'r')
    gdata4 = open(r'd:\a\score.txt','r')
    score=gdata4.read().split("\n")
    nameteam=gdata.read().split("\n")
    global maxi
    for i in range(0,8,1):
        if int(score[i])>maxi:
            maxi=int(score[i])
            keep=nameteam[i]
    print('{0:-<83}'.format(""))
    print('{0:|<1}{1:^81}{2:|<1}'.format("","Top scorer of the league is %s %d goals"%(keep,maxi),""))
    print('{0:-<83}'.format(""))
    gdata.close()
    gdata4.close()
    restart()
#********************************************************************************************************************************************************************************************************************
def printmath():
    print("\n\n\n")
    gdata1 = open(r'd:\a\match.txt','r')
    gdata3 = open(r'd:\a\checkteam.txt','r')
    gdata = open(r'd:\a\nameteam.txt', 'r')
    checkteam=gdata3.read().split("\n")
    nameteam=gdata.read().split("\n")
    match=gdata1.read().split("\n")
    n=int(int(len(match))/4)
    print('{0:-<83}'.format(""))
    print('{0:|<1}{1:^11}{2:|<1}{3:^30}{4:|<1}{5:^7}{6:|<1}{7:^30}{8:|<1}'.format("","MATCH NO.","","Home team","","Score","","Visiting team",""))
    print('{0:-<83}'.format(""))
    for i in range(0,n,1):
        print('{0:|<1}{1:^11}{2:|<1}{3:^30}{4:|<1}{5:^7}{6:|<1}{7:^30}{8:|<1}'.format("",i+1,"",nameteam[int(match[i*4])-1],"",match[i*4+1]+'-'+match[i*4+3],"",nameteam[int(match[i*4+2])-1],""))
        print('{0:-<83}'.format(""))
    gdata1.close()
    gdata3.close()
    gdata.close()
    restart()
#********************************************************************************************************************************************************************************************************************
def grape():
    print("\n\n\n")
    gdata5 = open(r'd:\a\topthree.txt','r')
    topthree=gdata5.read().split("\n")
    print("{0: <19}{1:^17}".format("",topthree[1]))
    print("{0: <19}{1:_<17}".format("",""))
    print("{0: <18}{1:|<1}{2: <17}{3:|<1}".format("","","",""))
    print("{0: <18}{1:|<1}{2: <17}{3:|<1}".format("","","",""))
    print("{0:^18}{1:|<1}{2: <17}{3:|<1}".format(topthree[2],"","",""))
    print("{0: <1}{1:_<17}{2:|<1}{3: <17}{4:|<1}".format("","","","",""))
    print("{0:|<1}{1: <17}{2:|<1}{3: <17}{4:|<1}".format("","","","",""))
    print("{0:|<1}{1: <17}{2:|<1}{3: <17}{4:|<1}".format("","","","",""))
    print("{0:|<1}{1: <17}{2:|<1}{3: <17}{4:|<1}{5:^17}{6: <1}{7:^17}".format("","","","","",topthree[3],"",topthree[4]))
    print("{0:|<1}{1: <17}{2:|<1}{3:^17}{4:|<1}{5:_<17}{6: <1}{7:_<17}".format("","","","1","","","",""))
    print("{0:|<1}{1: <17}{2:|<1}{3: <17}{4:|<1}{5: <17}{6:|<1}{7: <17}{8:|<1}".format("","","","","","","","",""))
    print("{0:|<1}{1:^17}{2:|<1}{3: <17}{4:|<1}{5: <17}{6:|<1}{7: <17}{8:|<1}".format("","2","","","","","","",""))
    print("{0:|<1}{1: <17}{2:|<1}{3: <17}{4:|<1}{5: <17}{6:|<1}{7: <17}{8:|<1}".format("","","","","","","","",""))
    print("{0:|<1}{1: <17}{2:|<1}{3: <17}{4:|<1}{5:^17}{6:|<1}{7:^17}{8:|<1}".format("","","","","","3","","3",""))
    print("{0:|<1}{1: <17}{2:|<1}{3: <17}{4:|<1}{5: <17}{6:|<1}{7: <17}{8:|<1}".format("","","","","","","","",""))
    print("{0:|<1}{1: <17}{2:|<1}{3: <17}{4:|<1}{5: <17}{6:|<1}{7: <17}{8:|<1}".format("","","","","","","","",""))
    print("{0:|<1}{1: <17}{2:|<1}{3: <17}{4:|<1}{5: <17}{6:|<1}{7: <17}{8:|<1}".format("","","","","","","","",""))
    gdata5.close()
    restart()
#********************************************************************************************************************************************************************************************************************
def totalscore():
    print("\n\n\n")
    gdata = open(r'd:\a\nameteam.txt', 'r')
    f=open(r'd:\a\checkteam.txt','r')
    nameteam=gdata.read().split("\n")
    checkteam=f.read().split("\n")
    for i in range(1,4,1):
        if i==1 or i==3:
            print('{0:-<69}'.format(""))
        else:
            print('{0:|<1}{1:3}{2:|<1}{3:^50}{4:|<1}{5:^12}{6:|<1}'.format("",'NO.',"","Nameteam","","Status",""))
    for i in range(0,9,1):
        if i==8:
            print('{0:-<69}'.format(""))
        else:
            print('{0:|<1}{1:1}{2:|<1}{3:1}{4:|<1}{5:^50}{6:|<1}{7:^12}{8:|<1}'.format(""," ",i+1," ","",nameteam[i],"",checkteam[i],""))
    gdata.close()
    f.close()
    restart()
#********************************************************************************************************************************************************************************************************************
def inputmatch():
    print("\n\n\n")
    global count
    global match
    gdata = open(r'd:\a\nameteam.txt','r')
    gdata4 = open(r'd:\a\score.txt','r')
    gdata6 = open(r'd:\a\count.txt','r')
    gdata3 = open(r'd:\a\checkteam.txt','r')
    count=int(gdata6.read())
    nameteam=gdata.read().split("\n")
    print('{0:-<66}'.format(""))
    print('{0:|<1}{1:^64}{2:|<1}'.format("","  Please Input Match  ",""))
    print('{0:-<66}'.format(""))
    count=count+4
    match.clear()
    match.append(input("Home team NO. :"))
    num=len(match)
    match.append(input("Score team %s :"%(nameteam[int(match[num-1])-1])))
    match.append(input("Visiting team NO. :"))
    num=len(match)
    match.append(input("Score team %s :"%(nameteam[int(match[num-1])-1])))
    gdata1 = open(r'd:\a\match.txt','a')
    for i in match:
        gdata1.write(i+"\n")
    gdata1.close()
    gdata1 = open(r'd:\a\match.txt','r')
    match=gdata1.read().split("\n")
    score=gdata4.read().split("\n")
    checkteam=gdata3.read().split("\n")
    score[int(match[count-4])-1]=int(score[int(match[count-4])-1])+int(match[count-3])
    score[int(match[count-2])-1]=int(score[int(match[count-2])-1])+int(match[count-1])
    if int(match[count-3])>int(match[count-1]):
        checkteam[int(match[count-2])-1]="Eliminated"
    else:
        checkteam[int(match[count-4])-1]="Eliminated"
    if count==20 :
        topthree[4]=nameteam[int(match[count-2])-1] if int(match[count-3])>int(match[count-1]) else nameteam[int(match[count-4])-1]
    if count==24:
        topthree[3]=nameteam[int(match[count-2])-1] if int(match[count-3])>int(match[count-1]) else nameteam[int(match[count-4])-1]
    if count==28:
        topthree[2]=nameteam[int(match[count-2])-1] if int(match[count-3])>int(match[count-1]) else nameteam[int(match[count-4])-1]
        topthree[1]=nameteam[int(match[count-4])-1] if int(match[count-3])>int(match[count-1]) else nameteam[int(match[count-2])-1]
    gdata3.close()
    gdata4.close()
    gdata3 = open(r'd:\a\checkteam.txt','w')
    gdata4 = open(r'd:\a\score.txt','w')
    gdata5 = open(r'd:\a\topthree.txt','w')
    for i in checkteam:
        gdata3.write(str(i)+"\n")
    for i in score:
        gdata4.write(str(i)+"\n")
    for i in topthree:
        gdata5.write(i+"\n")
    gdata6.close()
    gdata6 = open(r'd:\a\count.txt','w')
    gdata6.write(str(count))
    gdata.close()
    gdata1.close()
    gdata3.close()
    gdata4.close()
    gdata5.close()
    gdata6.close()
    restart()
#********************************************************************************************************************************************************************************************************************
def inputnameteam():
    gdata = open(r'd:\a\nameteam.txt','a')
    gdata3 = open(r'd:\a\checkteam.txt','w')
    gdata4 = open(r'd:\a\score.txt','a')
    gdata5 = open(r'd:\a\topthree.txt','a')
    gdata6 = open(r'd:\a\count.txt','w')
    gdata6.write("0")
    print('{0:-<83}'.format(""))
    print('{0:|<1}{1:^81}{2:|<1}'.format("","Welcome to program",""))
    print('{0:-<83}'.format(""))
    for i in range(0,8,1):
        gdata.write(input("Input your name team %d :"%(i+1))+"\n")
        gdata3.write("Selected"+"\n")
        gdata4.write("0"+"\n")
    for i in topthree: 
        gdata5.write(i+"\n")
    gdata.close()
    gdata3.close()
    gdata4.close()
    gdata5.close()
    gdata6.close()
    restart()
#*************************************************************************************************************************************************************************************************************************
def restart():
    ch = input("\n\n\n[1]Input Match,  [2]Show Status Team,  [3]Show Match,  [4]1st 2nd 3rd,  [5]Show Topscorer,  [6]Exit : ")
    if ch=='1':
        inputmatch()
    if ch=='2':
        totalscore()
    if ch=='3':
        printmath()
    if ch=='4':
        grape()
    if ch=='5':
        Topscorer()
    if ch=='6':
        return 0
#*************************************************************************************************************************************************************************************************************************
gdata = open(r'd:\a\nameteam.txt','a')
gdata.close()
gdata = open(r'd:\a\nameteam.txt','r')
num=gdata.read().split("\n")
gdata.close()
if len(num)<8:
    inputnameteam()
restart()