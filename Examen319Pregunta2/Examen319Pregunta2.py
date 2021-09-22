# -*- coding: utf-8 -*-
"""
Spyder Editor

This is a temporary script file.
"""

from pyswip import Prolog
prolog=Prolog()
prolog.assertz("padrede(juan,maria)")
prolog.assertz("padrede(pablo,juan)")
prolog.assertz("padrede(pablo,marcela)")
prolog.assertz("padrede(carlos,debora)")

list(prolog.query("padrede(juan,X)")) == [{'X':'maria'}]
list(prolog.query("padrede(pablo,X)")) == [{'X':'juan'},{'X':'marcela'}]
list(prolog.query("padrede(carlos,X)")) == [{'X':'debora'}]

for elemento in prolog.query("padrede(X,Y)"):
    print(elemento["X"],"es padre de",elemento["Y"])