#include <cmath>
#include <array>

std::array<double, 2> pq(double p, double q)
{
    std::array<double, 2> temp;
    if(pow(p, 2) - q >= 0) {
        temp = {
            -p/2 - sqrt(pow(p/2, 2) - q),
            -p/2 + sqrt(pow(p/2, 2) - q)
        };
        return temp;
    }
    throw std::runtime_error("Keine Nullstelle");
}

// Test
//std::cout << "x1 = " << pq(5, 5)[0] << std::endl;
//std::cout << "x2 = " << pq(5, 5)[1] << std::endl;
