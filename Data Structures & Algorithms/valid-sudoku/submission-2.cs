public class Solution {
    public bool IsValidSudoku(char[][] board) {
        
        HashSet<char>[] rows = new HashSet<char>[9];
        HashSet<char>[] cols = new HashSet<char>[9];
        HashSet<char>[] boxs = new HashSet<char>[9];

        for(int i = 0; i < 9;i++){
            rows[i] = new HashSet<char>();
            cols[i] = new HashSet<char>();
            boxs[i] = new HashSet<char>();
        }
        for(int r = 0; r < 9; r++){
            for(int c = 0; c < 9; c++){
                char value = board[r][c];

                if(value == '.')continue;
                 int boxIndex = (r/3)*3 + (c/3);
                if (rows[r].Contains(value) ||
                cols[c].Contains(value) ||
                boxs[boxIndex].Contains(value))
            {
                return false;
            }

            rows[r].Add(value);
            cols[c].Add(value);
            boxs[boxIndex].Add(value);

            }
        }
      return true;
    }
}
