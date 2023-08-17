import pygame as pg
from random import randrange

Window = 500
Tile_size = 40
Range = (Tile_size // 2, Window - Tile_size // 2, Tile_size)
get_random_position = lambda: [randrange(*Range), randrange(*Range)]
snake = pg.rect.Rect([0, 0, Tile_size - 2, Tile_size - 2])
snake.center = get_random_position()
length = 1
segment = [snake.copy()]
snake_dir = (0, 0)
time, time_step = 0, 130
food = snake.copy()
food.center = get_random_position()
screen = pg.display.set_mode([Window] * 2)
clock = pg.time.Clock()
dirs = {pg.K_w: 1, pg.K_s: 1, pg.K_a: 1, pg.K_d: 1}

while True:
    for event in pg.event.get():
        if event.type == pg.QUIT:
            exit()
        if event.type == pg.KEYDOWN:
            if event.key == pg.K_w and dirs[pg.K_w]:
                snake_dir = (0, -Tile_size)
                dirs = {pg.K_w: 1, pg.K_s: 0, pg.K_a: 1, pg.K_d: 1}
            if event.key == pg.K_s and dirs[pg.K_s]:
                snake_dir = (0, Tile_size)
                dirs = {pg.K_w: 0, pg.K_s: 1, pg.K_a: 1, pg.K_d: 1}
            if event.key == pg.K_a and dirs[pg.K_a]:
                snake_dir = (-Tile_size, 0)
                dirs = {pg.K_w: 1, pg.K_s: 1, pg.K_a: 1, pg.K_d: 0}
            if event.key == pg.K_d and dirs[pg.K_d]:
                snake_dir = (Tile_size, 0)
                dirs = {pg.K_w: 1, pg.K_s: 1, pg.K_a: 0, pg.K_d: 1}

    screen.fill('black')
    # Los borde check y se come solo
    self_eating = pg.Rect.collidelist(snake, segment[:-1]) != -1
    if snake.left < 0 or snake.right > Window or snake.top < 0 or snake.bottom > Window or self_eating:
        snake.center, food.center = get_random_position(), get_random_position()
        length, snake_dir = 1, (0, 0)
        segment = [snake.copy()]
    # Comida check
    if snake.center == food.center:
        food.center = get_random_position()
        length += 1
    # dibujo de comida
    pg.draw.rect(screen, 'blue',food)
    # dibujo culebra
    [pg.draw.rect(screen, 'yellow', segment) for segment in segment]
    # Movimiento de la culebra
    time_now = pg.time.get_ticks()
    if time_now - time > time_step:
        time = time_now
        snake.move_ip(snake_dir)
        segment.append(snake.copy())
        segment = segment[-length:]
    pg.display.flip()
    clock.tick(60)
