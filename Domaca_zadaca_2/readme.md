1.
trajalo je malo više od 5 sekundi.

2.
Sve su se opreacije izvodile na jednoj dretvi.

3.
trajalo je malo više od 1 sekunde.

4.
Svaka operacija se vrtila na svojoj dretvi.

5.
Može doći do nekoherentnosti podataka. Prva dretva učita podatak za uvećat, ali je nakon toga prekinuta i kreće rad druge dretve.
Druga dretva obavi cijeli niz operacija, sprema vrijednost i završava, ali u prvoj dretvi se ne nalazi podatak uvećan za jedan već njegova
stara vrijednost tako da će podatak ukupno biti povećan za jedan, a ne za dva.
