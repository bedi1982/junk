#include <stdio.h>
#include <stdlib.h>
#include <termios.h>

#define FIELD_WIDTH 60
#define FIELD_HEIGHT 40

struct link {
	int x, y;
	struct link *next;
};

struct snake {
	int dx, dy;
	int speed;
	struct link *head;
};

struct bait {
	int x, y;
	int val;
};


static struct termios term;
static struct bait bait;


void new_bait()
{
}

struct link *new_link(int x, int y)
{
	struct link *link;

	link = malloc(sizeof (struct link));
	if (link != NULL) {
		link->x = x;
		link->y = y;
		link->next = NULL;
	}

	return link;
}

int test_limits(struct snake *snake)
{
	if (snake->head->x < 0 || snake->head->x >= FIELD_WIDTH)
		return -1;

	if (snake->head->y < 0 || snake->head->y >= FIELD_HEIGHT)
		return -1;

	return 0;
}

int move_snake(struct snake *snake)
{
	struct link *link;

	for (link = snake->head; link; link = link->next) {
		if (link->next->next == NULL) {
			struct link *tail = link->next;
			link->next = NULL;		/* remove tail */
			tail->x = snake->head->x + snake->dx;
			tail->y = snake->head->y + snake->dy;
			tail->next = snake->head;	/* insert new link */
			snake->head = tail;		/* update head */
			break;
		}
	}

	return test_limits(snake);
}

int grow_snake(struct snake *snake)
{
	struct link *link;

	link = new_link(snake->head->x + snake->dx, snake->head->y + snake->dy);
	link->next = snake->head;
	snake->head = link;

	return test_limits(snake);
}

void draw_field(struct snake *snake)
{
	int i, j;
	struct link *link;

	for (i = 0; i < FIELD_HEIGHT; i++) {
		for (j = 0; j < FIELD_WIDTH; j++) {
			int flag = 0;

			for (link = snake->head; link; link = link->next) {
				if (link->x == j && link->y == i) {
					flag = 1;
				}
			}
			printf(flag ? "O" : ".");
		}
		printf("\n");
	}
}

void check_snake(struct snake *snake)
{
	struct link *link;

	for (link = snake->head; link; link = link->next) {
		printf("link: x=%d, y=%d\n", link->x, link->y);
	}
}


static int set_tty()
{
    struct termios t;

    if (tcgetattr (0, &term) < 0)
	return -1;

    t = term;
    t.c_lflag &= ~(ECHO | ICANON | TOSTOP);
    t.c_cc[VMIN] = t.c_cc[VTIME] = 0;

    if (tcsetattr (0, TCSAFLUSH, &t) < 0)
	return -1;

    return 0;
}

static void reset_tty()
{
	tcsetattr(0, TCSAFLUSH, &term);
}

int main()
{
	struct snake snake;
	int i, k;
	char cmd;

	atexit(reset_tty);
	set_tty();

	snake.head = new_link(FIELD_WIDTH / 2, FIELD_HEIGHT / 2);
	snake.dx = 0;
	snake.dy = -1;
	snake.speed = 3;

	grow_snake(&snake);
	grow_snake(&snake);
	grow_snake(&snake);

	do {
		draw_field(&snake);
		printf("\n");

		for (k = i = 0; i < snake.speed; i++) {
			usleep(100000);
			if (k == 0 && read(0, &cmd, 1) == 1) {
				k = cmd;
			}
		}

		switch (k) {
		case 'k':
			snake.dx = 0;
			snake.dy = -1;
			break;
		case 'j':
			snake.dx = 0;
			snake.dy = 1;
			break;
		case 'l':
			snake.dx = 1;
			snake.dy = 0;
			break;
		case 'h':
			snake.dx = -1;
			snake.dy = 0;
			break;
		}	
	} while (move_snake(&snake) == 0);

	printf("FAIL!\n");
}
	

