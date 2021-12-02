//Not standard convention to use I infront of an interface for typescript (it is convention for C#)
export interface Activity {
    id: string;
    title: string;
    date: string; //Will deal with this later
    description: string;
    category: string;
    city: string;
    venue: string;
}