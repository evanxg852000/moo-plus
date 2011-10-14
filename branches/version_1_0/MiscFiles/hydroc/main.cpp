#include <iostream>
#include <fstream>
using namespace std;

int main()
{
    ofstream myfile;
    myfile.open ("PlaceHolder.BAT");
    myfile << "ECHO This is a place holder compiler ! \n";
    myfile << "ECHO It generate the same Output any time ! \n";
    myfile << "ECHO You will be notify for the Hydro compiler release ! \n";
    myfile << "ECHO Evansofts Tm 2010 (evance soumaoro) ! \n";
    myfile.close();
    cout<<"-----------------Evansofts Corporation-------------\n";
    cout << "This is a place holder compiler ! \n";
    cout << "It generate the same Output any time ! \n";
    cout << "You will be notify for the Hydro compiler release ! \n";
    cout << "Evansofts Tm 2010 (Evance soumaoro) ! \n";
    return 0;
}
