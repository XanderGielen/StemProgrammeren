films = ["Monty Python and the Holy Grail", "Monty Python ' s Life of Brian", "Monty Python ' s Meaning of Life", "And Now For Something Completely Different"]
grail_scores = [ 9, 10, 9.5, 8.5, 3, 7.5 ,8 ]
brian_scores = [ 10, 10, 0, 9, 1, 8, 7.5, 8, 6, 9 ]
life_scores = [ 7, 6, 5 ]
different_scores = [ 6, 5, 6, 6 ]

dict = {
    films[0] : grail_scores,
    films[1] : brian_scores,
    films[2] : life_scores,
    films[3] : different_scores
}
print(round(sum(dict[films[0]]) / len(dict[films[0]]), 1))
