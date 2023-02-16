import java.sql.Date;
import java.text.ParseException;
import java.text.SimpleDateFormat;

public class MyDate {
    private int Month, Day, Year;
    private int bmonth, bday;
    // main constuctor

    MyDate() {
        this.Month = 10;
        this.Day = 12;
        this.Year = 2020;
    }

    // secondary constructor
    MyDate(int m, int d, int y) {
        if (isDateValid(m, d, y) == true) {
            this.Month = m;
            this.Day = d;
            this.Year = y;
        } else {
            this.Month = 10;
            this.Day = 12;
            this.Year = 2020;
        }
    }

    // 3rd constructor
    public MyDate(String date) {
        // 07/23/2004 --> ["07", "23", "2004"]
        String[] input = date.split("/");

        //int m = Integer.parseInt(date.substring(0,2)); --> "07" --> 7
        //int d = Integer.parseInt(date.substring(3,5)); --> "23" --> 23
        //int y = Integer.parseInt(date.substring(7)); --> "2004" --> 2004

        int m = Integer.parseInt(input[0]);
        int d = Integer.parseInt(input[1]);
        int y = Integer.parseInt(input[2]);

        if (isDateValid(m, d, y)) {
            this.Month = m;
            this.Day = d;
            this.Year = y;
        } else {
            this.Month = 10;
            this.Day = 12;
            this.Year = 2020;
        }
    }


//// these are my setters

    public void setMonth(int m) {
        if (isDateValid(m, Day, Year)) {
            this.Month = m;
        }
    }


    public void setYear(int y) {
        if (isDateValid(Month, Day, y)) {
            this.Year = y;
        }
    }

    public void setDay(int d) {
        if (isDateValid(Month, d, Year)) {
            this.Day = d;
        }
    }


    public int getMonth() {
        return this.Month;
    }

    public int getYear() {
        return this.Year;
    }

    public int getDay() {
        return this.Day;
    }

    public void setDate(int m, int d, int y) {
        if (isDateValid(m, d, y)) {
            this.Year = y;
            this.Day = d;
            this.Month = m;
        }
    }


    public boolean isMyBirthday(int m, int d) {
        if (m == this.Month && d == this.Day) {
            return true;
        } else {
            return false;
        }
    }

    public boolean isLeapYear(int y) {
        if (y % 100 == 0) {
            if (y % 400 == 0) {
                return true;
            } else {
                return false;
            }
        }
        if (y % 4 == 0 && y % 100 != 0) {
            return true;
        } else {
            return false;
        }
    }

    private int getLastDayOfMonth(int m, int y) {
        if (m == 1) {
            return 31;
        }
        if (m == 2) {
            if (isLeapYear(y) == true) {
                return 29;
            }
            ;
            if (isLeapYear(y) == false) {
                return 28;
            }
        }
        if (m == 3) {
            return 31;
        }
        if (m == 4) {
            return 30;
        }
        if (m == 5) {
            return 31;
        }
        if (m == 6) {
            return 30;
        }
        if (m == 7) {
            return 31;
        }
        if (m == 8) {
            return 31;
        }
        if (m == 9) {
            return 30;
        }
        if (m == 10) {
            return 31;
        }
        if (m == 11) {
            return 30;
        }
        if (m == 12) {
            return 31;
        }


        return 0;
    }

    private boolean isDateValid(int m, int d, int y) {

        if (y > 0) {
            // month check
            if (m > 0 && m < 13) {
                if (m == 1) {
                    if (d > 0 && d < 32) {
                        return true;
                    } else {
                        return false;
                    }
                } else if (m == 2) {
                    // if leap year is true
                    if (isLeapYear(y)) {
                        if (d > 0 && d < 30) {
                            return true;
                        } else {
                            return false;
                        }
                    }

                    // if leap year is false
                    else {
                        if (d > 0 && d < 29) {
                            return true;
                        } else {
                            return false;
                        }
                    }
                } else if (m == 3) {
                    if (d > 0 && d < 32) {
                        return true;
                    } else {
                        return false;
                    }
                } else if (m == 4) {
                    if (d > 0 && d < 31) {
                        return true;
                    } else {
                        return false;
                    }
                } else if (m == 5) {
                    if (d > 0 && d < 32) {
                        return true;
                    } else {
                        return false;
                    }
                } else if (m == 6) {
                    if (d > 0 && d < 31) {
                        return true;
                    } else {
                        return false;
                    }
                } else if (m == 7) {
                    if (d > 0 && d < 32) {
                        return true;
                    } else {
                        return false;
                    }
                } else if (m == 8) {
                    if (d > 0 && d < 32) {
                        return true;
                    } else {
                        return false;
                    }
                } else if (m == 9) {
                    if (d > 0 && d < 31) {
                        return true;
                    } else {
                        return false;
                    }
                } else if (m == 10) {
                    if (d > 0 && d < 32) {
                        return true;
                    } else {
                        return false;
                    }
                } else if (m == 11) {
                    if (d > 0 && d < 31) {
                        return true;
                    } else {
                        return false;
                    }
                } else if (m == 12) {
                    if (d > 0 && d < 32) {
                        return true;
                    } else {
      return false;
                    }
                } else {
                    return false;
                }
            } else {
                return false;
            }
        }
        // if month is less than 0 or greater than 12 than its is false
        else {
            return false;
        }

    }

    public String toString() {
        // IF you wanted a zero-padded date string:
        // Replace %d with %02d --> %d, 0 is the padding character, 2 is the number of printed characters
        // So, 2 would become "02", 9 would be "09", but 10 or higher, just the same value (10, 11, 12, etc.)
        return String.format("%d/%d/%d", this.Month, this.Day, this.Year);
    }

    public String toString(int format) throws ParseException {
        if (format == 1) {
            return String.format("%d/%d/%d", this.Month, this.Day, this.Year);
        }
        if (format == 2) {
            return String.format("%02d/%d/%d", this.Month, this.Day, this.Year);
        }
        if (format == 3) {
      /// need to turn the 07/10/2014 into Sep 10 2019--
            Date thisDate = new Date(this.Month, this.Day, this.Year);
                SimpleDateFormat dateForm = new SimpleDateFormat("MMM dd, Y");

            return dateForm.format(thisDate);
        }
        if (format == 4) {
            switch (Month) {
                case 1:
                    return String.format("January/%d/%d", this.Day, this.Year);
                case 2:
                    return String.format("Febuary/%d/%d", this.Day, this.Year);
                case 3:
                    return String.format("March/%d/%d", this.Day, this.Year);
                case 4:
                    return String.format("April/%d/%d", this.Day, this.Year);
                case 5:
                    return String.format("May/%d/%d", this.Day, this.Year);
                case 6:
                    return String.format("June/%d/%d", this.Day, this.Year);
                case 7:
                    return String.format("July/%d/%d", this.Day, this.Year);
                case 8:
                    return String.format("August/%d/%d", this.Day, this.Year);
                case 9:
                    return String.format("September/%d/%d", this.Day, this.Year);
                case 10:
                    return String.format("October/%d/%d", this.Day, this.Year);
                case 11:
                    return String.format("November/%d/%d", this.Day, this.Year);
                case 12:
                    return String.format("December/%d/%d", this.Day, this.Year);
                default:
                    return " ";
            }

        } else {
            return "";
        }


    }


    public void nextDay() {
        Day = Day + 1;
        int d;
        d = getLastDayOfMonth(Month, Year);
        if(Day > d){
            Day = 1;
            Month = Month + 1;
        }
        if(Month > 12){
            Month = 1;
            Year = Year + 1;
        }

            }
            public boolean equals(MyDate otherDate){
            if(otherDate.Year == Year && otherDate.Month == Month && otherDate.Day == Day){return true;}
            else{return false;}

            }
            public void skipAhead(int numDays ){
                    if(numDays > 0){
                    for(int i = 0; i < numDays; i++){
                        nextDay();
                    }
                    }
            }
}