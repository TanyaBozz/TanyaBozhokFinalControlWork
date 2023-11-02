# Описание решения итоговой задачи

---
### Функции, использованные в программе:

- **<span style="color:#D6D079">ValidateInputCountElement</span>(<span style="color:#2659B9">int</span> <span style="color:#6CCAFE">validateValue</span>)** - используется для проверки количества элементов в первичном массиве (от 1 до 10).
- **<span style="color:#D6D079">FillPrimaryArray</span>(<span style="color:#2659B9">string</span><span style="color:#8763D0">[]</span><span style="color:#6CCAFE">fillableArray</span>)** - используется для заполнения первичного массива из терминала.
- **<span style="color:#D6D079">CountSecondaryArrayElements</span>(<span style="color:#2659B9">string</span><span style="color:#8763D0">[]</span> <span style="color:#6CCAFE">filledArray</span>)** - используется для определения количества элементов во вторичном массиве посредством фильтрации элементов первичного массива, с учетом параметров, указанных в задаче.
- **<span style="color:#D6D079">FillSecondaryArray</span>(<span style="color:#2659B9">string</span><span style="color:#8763D0">[]</span> <span style="color:#6CCAFE">filledPrimaryArray</span>, <span style="color:#2659B9">string</span><span style="color:#8763D0">[]</span> <span style="color:#6CCAFE">emptySecondaryArray</span>)** - используется для заполнения вторичного массива посредством  фильтрации элементов первичного массива, с учетом параметров, указанных в задаче. 
- **<span style="color:#D6D079">PrintArray</span>(<span style="color:#2659B9">string</span><span style="color:#8763D0">[]</span> <span style="color:#6CCAFE">arr</span>)** - используется для вывода массива в терминал. 


---

### Алгоритм работы программы
В первую очередь, указываем, сколько элементом в первичном массиве, путем ввода количества элементов в терминале.
Далее, проверяем введенное значение (значение должно быть от 1 до 10), используя функцию **<span style="color:#D6D079">ValidateInputCountElement</span>**. Если введенное значение некорректно - заканчиваем работу программы и выводим в терминал ошибку.
Если значение введенно верно - создаем первичным массив и заполняем его путем ввода значений массива из терминала используя функцию **<span style="color:#D6D079">FillPrimaryArray</span>**.
После узнаем количество элементов для вторичного массива, фильтруя элементы первичного массива по параметрам, указанным в задаче, использую функцию **<span style="color:#D6D079">CountSecondaryArrayElements</span>**.
Создаем вторичный массив и также заполняем его по параметрам, указанным в задаче, используя функцию **<span style="color:#D6D079">FillSecondaryArray</span>**. В последствии выводим первичный и вторичный массив, используя функцию **<span style="color:#D6D079">PrintArray</span>**.
