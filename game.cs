using System;
using System.Collections.Generic;
namespace FloGame
{
    public class gridPos {
        public bool hasLight;
        public bool state;
        public double x, z;

        public gridPos(double x2,double z2,bool light,bool isOn) {
            hasLight = light;
            state = isOn;
            x = z2;
            z = z2;
        }

        public void toggleLight(){
            state = !state;
        }
    }

    public class edge {
        public double start,end;

        public edge(double start2, double end2) {
            start = start2;
            end = end2;
        }
    }

    public class TFPlayer {
        public gridPos start, end;
        public int color;

        public TFPlayer(int color2, gridPos start2, gridPos end2){
            color = color2;
            start = start2;
            end = end2;
        }
    }

    public class Car {
        public int[] path;
        public int color;
        public bool finished;
        public bool hasSpawned = false;

        public Car(int[] path2, int color2){
            path = path2;
            color = color2;
        }
        public void spawn(){
            hasSpawned = true;
            finished = false;
            color = this.color;
        }
    }

    public class gameSpace {
        public LinkedList<edge>[] graph;
        public int state;

        public gameSpace(LinkedList<edge>[] graph2){
            graph = graph2;
        }
    }

    public class Flo {

        static void Main(string[] args){
            TFPlayer player1, player2;
            int numCars, pathLength;
            int numPositions = 24;
            gameSpace floGame;

            gridPos[] nodes = new gridPos[numPositions];

            double y = -15.44;

            gridPos spawn1 = new gridPos(70.4,-66.3,false,false);
            gridPos spawn2 = new gridPos(70.4,-105.5,false,false);
            gridPos goal1 = new gridPos(-107.2,-66.3,false,false);
            gridPos goal2 = new gridPos(-107.2,-105.5,false,false);

            nodes[0] = new gridPos(-56.9,-73.44,true,true);
            nodes[1] = new gridPos(-37.04,-73.44,true,true);
            nodes[2] = new gridPos(-29.02,-73.44,true,true);
            nodes[3] = new gridPos(-9.04,-73.44,true,true);
            nodes[4] = new gridPos(42.6,-73.44,true,true);
            nodes[5] = new gridPos(50.61,-73.44,true,true);
            nodes[6] = new gridPos(70.59,-73.44,true,true);
            nodes[7] = new gridPos(90.64,-73.44,true,true);

            nodes[8] = new gridPos(-56.9,-93.44,true,true);
            nodes[9] = new gridPos(-37.04,-93.44,true,true);
            nodes[10] = new gridPos(-29.02,-93.44,true,true);
            nodes[11] = new gridPos(-9.04,-93.44,true,true);
            nodes[12] = new gridPos(42.6,-93.44,true,true);
            nodes[13] = new gridPos(50.61,-93.44,true,true);
            nodes[14] = new gridPos(70.59,-93.44,true,true);
            nodes[15] = new gridPos(90.64,-93.44,true,true);

            nodes[16] = new gridPos(-56.9,-113.44,true,true);
            nodes[17] = new gridPos(-37.04,-113.44,true,true);
            nodes[18] = new gridPos(-29.02,-113.44,true,true);
            nodes[19] = new gridPos(-9.04,-113.44,true,true);
            nodes[20] = new gridPos(42.6,-113.44,true,true);
            nodes[21] = new gridPos(50.61,-113.44,true,true);
            nodes[22] = new gridPos(70.59,-113.44,true,true);
            nodes[23] = new gridPos(90.64,-113.44,true,true);

            LinkedList<edge>[] graph = new LinkedList<edge>[numPositions];
            for (int i = 0; i < graph.Length; ++i)
            {
                graph[i] = new LinkedList<edge>();
            }

            for (int i = 0; i < graph.Length; i+=8)
            {
                graph[i].AddLast(new edge(i+1,0));
                graph[i].AddLast(new edge(i+4,0));
                graph[i+1].AddLast(new edge(i+0,0));
                graph[i+1].AddLast(new edge(i+2,0));
                graph[i+1].AddLast(new edge(i+5,0));
                graph[i+2].AddLast(new edge(i+1,0));
                graph[i+2].AddLast(new edge(i+6,0));
                graph[i+2].AddLast(new edge(i+3,0));
                graph[i+3].AddLast(new edge(i+2,0));
                graph[i+3].AddLast(new edge(i+7,0));
           }
            gameSpace field = new gameSpace(graph);
            player1 = new TFPlayer(0, spawn1, goal1);
            player2 = new TFPlayer(1, spawn2, goal2);

        }
    }
}







