#!/bin/bash

clear

echo "a) bestanden aanmaken"
echo "b) bestand checken"
echo "c) bestand wissen"

read -p "kies een optie (a/b/c): " input
teller=0

if [ $input = "a" ]; then
        clear
        read -p "Voer een naam in: " inputNaam
        read -p "Voer een getal in: " inputGetal
        while [ $teller -lt $inputGetal ]
        do
                touch $inputNaam$teller.txt
                teller=$(($teller+1))
        done
        ls
elif [ $input = "b" ]; then
        clear
        read -p "In welke directory moet een bestand gecheckt worden? " inputDir
        read -p "Voer een bestandsnaam in: " inputBestandsNaam
        cd $inputDir 2> error.txt
        if [ -e $inputBestandsNaam ]; then
                echo "Bestaat."
        else
                echo "Bestaat niet."
        fi
elif [ $input = "c" ]; then
        clear
        read -p "In welke directory moet een bestand gecheckt worden? " inputDir
        read -p "Voer een bestandsnaam in: " inputBestandsNaam
        if [ -e $inputBestandsNaam ]; then
                rm $inputBestandsNaam
        fi
fi
