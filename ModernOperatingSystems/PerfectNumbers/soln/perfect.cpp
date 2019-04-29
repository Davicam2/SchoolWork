/*
 * Compute whether a given number is a perfect number, as described
 * in problem #64 in the textbook.
 */

#include <stdio.h>
#include <pthread.h>
#include <cstdlib>
#include <ctime>

pthread_mutex_t the_mutex;

size_t N, P;
int* factors;
int numFactors = 0;
int sum;

struct start_end {
  start_end() {}
  start_end(int start_, int end_) : start(start_), end(end_) {}
  int start, end;
};

void* check(void *ptr) {
  size_t start = (size_t)ptr;
  for (size_t i = start; i < N; i+=P) {
    if (N % i == 0) {
      pthread_mutex_lock(&the_mutex);
      sum += i;
      pthread_mutex_unlock(&the_mutex);
    }
  }
  pthread_exit(0);
}

int main(int argc, char **argv) {
  std::clock_t start = std::clock();

  if (argc < 3) {
    printf("Usage: perfect N P\n");
    return 1;
  }
  N = atoi(argv[1]);
  P = atoi(argv[2]);

  pthread_t* threads = new pthread_t[P];

  sum = 1;
  pthread_mutex_init(&the_mutex, NULL);	
  for (int t = 0; t < P && t < N-2; ++t) {
    pthread_create(&threads[t], NULL, check, (void*)(size_t)(t+2));
  }

  for (int t = 0; t < P && t < N; ++t) {
    pthread_join(threads[t], NULL);
  }
  pthread_mutex_destroy(&the_mutex);

  if (sum == N) {
    printf("%d is a perfect number.\n", N);
  } else {
    printf("%d is not a perfect number. The sum of the factors is %d.\n",
           N, sum);
  }

  double duration = ( std::clock() - start ) / (double) CLOCKS_PER_SEC;
  printf("duration = %lf\n", duration);
}
