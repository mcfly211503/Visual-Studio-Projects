#include <iostream>
using namespace std;
int main()
{
    int a, b, c, o=1;
    float d, e, f;
    while (o !=4)
    {
        cout << "Ingrese la opcion deseada" << endl << "1. Circulo" << endl << "2.Rectangulo" << endl << "3.Triangulo" << endl<<"4. Salir"<<endl;
        cin >> o;
        
        switch (o)
        {
        case 1:
            cout << "Ingrese el radio" << endl;
            cin >> e;
            d = 3.141592 * (e) * (e);
            cout << "SU area es: " << d << " u²" << endl;
            
            break;
        case 2:
            cout << "Ingrese base y altura separaos de enter" << endl;
            cin >> d;
            cin >> e;
            cout << "el area es de " << d * e << " u²" << endl;
            break;
        case 3:
            cout << "Ingrese base y altura separaos de enter" << endl;
            cin >> d;
            cin >> e;
            f = (d * e) / 2;
            cout << "el area es de " << f<< " u²" << endl;
            break;
        
        }
    }
}
