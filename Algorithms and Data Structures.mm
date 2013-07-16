<map version="0.9.0">
<!-- To view this file, download free mind mapping software FreeMind from http://freemind.sourceforge.net -->
<node CREATED="1359965032396" ID="ID_658071377" MODIFIED="1359973514738" TEXT="Root">
<font NAME="SansSerif" SIZE="12"/>
<node CREATED="1359965032396" ID="ID_557277033" MODIFIED="1359973518739" POSITION="right" STYLE="fork" TEXT="Algorithms">
<font NAME="SansSerif" SIZE="12"/>
<node CREATED="1359965153304" ID="ID_329795853" MODIFIED="1359973512320" TEXT="String Algorithms">
<font NAME="SansSerif" SIZE="12"/>
<node CREATED="1359968921847" ID="ID_28873787" MODIFIED="1359973512320" TEXT="Longest-prefix matching">
<font NAME="SansSerif" SIZE="12"/>
<node CREATED="1359969143329" ID="ID_459607360" MODIFIED="1359990148500">
<richcontent TYPE="NODE"><html>
  <head>
    
  </head>
  <body>
    <p>
      <b>Trie (Prefix Tree)</b>
    </p>
  </body>
</html></richcontent>
<font NAME="SansSerif" SIZE="12"/>
</node>
</node>
<node CREATED="1359971221133" ID="ID_830149615" MODIFIED="1359973512320" TEXT="Longest palindromic substring">
<font NAME="SansSerif" SIZE="12"/>
<node CREATED="1359971758035" ID="ID_997434894" MODIFIED="1359990141668">
<richcontent TYPE="NODE"><html>
  <head>
    
  </head>
  <body>
    <p>
      <b>Suffix Tree</b>
    </p>
  </body>
</html></richcontent>
<font NAME="SansSerif" SIZE="12"/>
</node>
<node CREATED="1359971814284" ID="ID_1756735390" MODIFIED="1359973512320">
<richcontent TYPE="NODE"><html>
  <head>
    
  </head>
  <body>
    <p>
      <b>Manacher's algorithm</b>
    </p>
    <p>
      http://leetcode.com/2011/11/longest-palindromic-substring-part-ii.html
    </p>
  </body>
</html></richcontent>
<font NAME="SansSerif" SIZE="12"/>
<attribute_layout NAME_WIDTH="99" VALUE_WIDTH="99"/>
<attribute NAME="Time Complexity" VALUE="n"/>
<attribute NAME="Space Complexity" VALUE="n"/>
</node>
<node CREATED="1359972069430" ID="ID_1947272918" MODIFIED="1359973512320">
<richcontent TYPE="NODE"><html>
  <head>
    
  </head>
  <body>
    <p>
      <b>Dynamic Programming</b>
    </p>
    <p>
      http://leetcode.com/2011/11/longest-palindromic-substring-part-i.html
    </p>
  </body>
</html></richcontent>
<font NAME="SansSerif" SIZE="12"/>
</node>
</node>
<node CREATED="1359970197799" ID="ID_1852598673" MODIFIED="1359973512320" TEXT="Longest common substring">
<font NAME="SansSerif" SIZE="12"/>
<node CREATED="1359970253292" ID="ID_943524393" MODIFIED="1359973512320">
<richcontent TYPE="NODE"><html>
  <head>
    
  </head>
  <body>
    <p>
      <b>Suffix Tree</b>
    </p>
    <p>
      - Building a generalised suffix tree for the strings,
    </p>
    <p>
      and then finding the deepest internal nodes which
    </p>
    <p>
      have leaf nodes from all the strings in the subtree below it.
    </p>
  </body>
</html></richcontent>
<font NAME="SansSerif" SIZE="12"/>
<attribute_layout NAME_WIDTH="93" VALUE_WIDTH="93"/>
<attribute NAME="Time Complexity" VALUE="n"/>
<attribute NAME="Preprocessing" VALUE="n"/>
</node>
<node CREATED="1359970551848" ID="ID_170966406" MODIFIED="1359973512320">
<richcontent TYPE="NODE"><html>
  <head>
    
  </head>
  <body>
    <p>
      <b>Dynamic Programming</b>
    </p>
    <p>
      - The maximum of longest common suffixes for every prefix
    </p>
    <p>
      - These are shown as diagonals (array)
    </p>
  </body>
</html></richcontent>
<font NAME="SansSerif" SIZE="12"/>
<attribute_layout NAME_WIDTH="99" VALUE_WIDTH="99"/>
<attribute NAME="Time Complexity" VALUE="m n"/>
<attribute NAME="Space Complexity" VALUE="min(m,n)"/>
</node>
</node>
<node CREATED="1359965609761" ID="ID_1394655440" MODIFIED="1359973512320" TEXT="Search Algorithms">
<font NAME="SansSerif" SIZE="12"/>
<node CREATED="1359965623057" ID="ID_1509862396" MODIFIED="1359973512320" TEXT="Naive algorithm">
<font BOLD="true" NAME="SansSerif" SIZE="12"/>
<attribute_layout NAME_WIDTH="93" VALUE_WIDTH="93"/>
<attribute NAME="Time Complexity" VALUE="(n-m+1) m"/>
<attribute NAME="Preprocessing" VALUE="0"/>
</node>
<node CREATED="1359965623057" ID="ID_265612767" MODIFIED="1359973512320" TEXT="Rabin-Karp algorithm">
<font BOLD="true" NAME="SansSerif" SIZE="12"/>
<attribute_layout NAME_WIDTH="93" VALUE_WIDTH="93"/>
<attribute NAME="Time Complexity" VALUE="n+m"/>
<attribute NAME="Preprocessing" VALUE="m"/>
</node>
<node CREATED="1359965623057" ID="ID_314756634" MODIFIED="1359973512320" TEXT="Finite-state machine search">
<font BOLD="true" NAME="SansSerif" SIZE="12"/>
<attribute_layout NAME_WIDTH="93" VALUE_WIDTH="93"/>
<attribute NAME="Time Complexity" VALUE="n"/>
<attribute NAME="Preprocessing" VALUE="m"/>
</node>
<node CREATED="1359965623057" ID="ID_957661247" MODIFIED="1359973512320" TEXT="Knuth-Morris-Pratt algorithm">
<font BOLD="true" NAME="SansSerif" SIZE="12"/>
<attribute_layout NAME_WIDTH="93" VALUE_WIDTH="93"/>
<attribute NAME="Time Complexity" VALUE="n"/>
<attribute NAME="Preprocessing" VALUE="m"/>
</node>
<node CREATED="1359965623057" ID="ID_1441373728" MODIFIED="1362112222012" TEXT="Boyer-Moore algorithm">
<font BOLD="true" NAME="SansSerif" SIZE="12"/>
<attribute_layout NAME_WIDTH="93" VALUE_WIDTH="93"/>
<attribute NAME="Time Complexity" VALUE="n/m"/>
<attribute NAME="Preprocessing" VALUE="m"/>
</node>
<node CREATED="1359965623057" ID="ID_1172584323" MODIFIED="1359973512320" TEXT="Bitap algorithm">
<font BOLD="true" NAME="SansSerif" SIZE="12"/>
<attribute_layout NAME_WIDTH="93" VALUE_WIDTH="93"/>
<attribute NAME="Time Complexity" VALUE="m n"/>
<attribute NAME="Preprocessing" VALUE="m"/>
</node>
</node>
</node>
<node CREATED="1359965203227" ID="ID_1639059129" MODIFIED="1359973512320" TEXT="Sorting Algorithms">
<font NAME="SansSerif" SIZE="12"/>
<node CREATED="1359965220914" ID="ID_1574751671" MODIFIED="1359973512320">
<richcontent TYPE="NODE"><html>
  <head>
    
  </head>
  <body>
    <p>
      <b>Quicksort</b>
    </p>
    <p>
      - Average case performance is faster than mergesort
    </p>
    <p>
      (Real world data is not shuffeled)
    </p>
    <p>
      - Assuming constant time to access any data
    </p>
    <p>
      (memory vs. disk)
    </p>
  </body>
</html></richcontent>
<font NAME="SansSerif" SIZE="12"/>
<attribute_layout NAME_WIDTH="99" VALUE_WIDTH="99"/>
<attribute NAME="Time Complexity" VALUE="n log n"/>
<attribute NAME="Space Complexity" VALUE="log n"/>
</node>
<node CREATED="1359965220914" ID="ID_165376817" MODIFIED="1359988502443">
<richcontent TYPE="NODE"><html>
  <head>
    
  </head>
  <body>
    <p>
      <b>Merge sort</b>
    </p>
    <p>
      - Preferred if data has to be sorted on disk
    </p>
    <p>
      (sequential data reading)
    </p>
  </body>
</html></richcontent>
<font NAME="SansSerif" SIZE="12"/>
<attribute_layout NAME_WIDTH="99" VALUE_WIDTH="99"/>
<attribute NAME="Time Complexity" VALUE="n log n"/>
<attribute NAME="Space Complexity" VALUE="n"/>
</node>
<node CREATED="1359965220914" ID="ID_1690062340" MODIFIED="1359988857904">
<richcontent TYPE="NODE"><html>
  <head>
    
  </head>
  <body>
    <p>
      <b>Intro sort</b>
    </p>
    <p>
      - Combination of Quick and Heap sort
    </p>
  </body>
</html></richcontent>
<arrowlink DESTINATION="ID_1574751671" ENDARROW="Default" ENDINCLINATION="138;0;" ID="Arrow_ID_889016564" STARTARROW="None" STARTINCLINATION="138;0;"/>
<arrowlink DESTINATION="ID_1765148224" ENDARROW="Default" ENDINCLINATION="100;0;" ID="Arrow_ID_1735824534" STARTARROW="None" STARTINCLINATION="100;0;"/>
<font NAME="SansSerif" SIZE="12"/>
<attribute_layout NAME_WIDTH="99" VALUE_WIDTH="99"/>
<attribute NAME="Time Complexity" VALUE="n log n"/>
<attribute NAME="Space Complexity" VALUE="log n"/>
</node>
<node CREATED="1359965220914" ID="ID_1765148224" MODIFIED="1359988932183">
<richcontent TYPE="NODE"><html>
  <head>
    
  </head>
  <body>
    <p>
      <b>Heap sort</b>
    </p>
    <p>
      - No locality of memory access
    </p>
    <p>
      (like quicksort, memory cache)
    </p>
  </body>
</html></richcontent>
<font NAME="SansSerif" SIZE="12"/>
<attribute_layout NAME_WIDTH="99" VALUE_WIDTH="99"/>
<attribute NAME="Time Complexity" VALUE="n log n"/>
<attribute NAME="Space Complexity" VALUE="1"/>
</node>
<node CREATED="1359965220914" ID="ID_1179042204" MODIFIED="1359988498980" TEXT="Insertion sort">
<font BOLD="true" NAME="SansSerif" SIZE="12"/>
<attribute_layout NAME_WIDTH="99" VALUE_WIDTH="99"/>
<attribute NAME="Time Complexity" VALUE="n&#xb2;"/>
<attribute NAME="Space Complexity" VALUE="1"/>
</node>
<node CREATED="1359965220914" ID="ID_1324660488" MODIFIED="1359973512320" TEXT="Bubble sort">
<font BOLD="true" NAME="SansSerif" SIZE="12"/>
<attribute_layout NAME_WIDTH="93" VALUE_WIDTH="93"/>
<attribute NAME="Time Complexity" VALUE="n&#xb2;"/>
<attribute NAME="Space Complexity" VALUE="1"/>
</node>
</node>
<node CREATED="1359967642167" ID="ID_1770205194" MODIFIED="1359973512320" TEXT="Randomized Algorithms">
<font NAME="SansSerif" SIZE="12"/>
<node CREATED="1359967683771" ID="ID_1319630830" MODIFIED="1359988496765">
<richcontent TYPE="NODE"><html>
  <head>
    
  </head>
  <body>
    <p>
      <b>Reservoir sampling</b>
    </p>
    <p>
      - Random entry in a large list (unknown length)
    </p>
  </body>
</html></richcontent>
<font NAME="SansSerif" SIZE="12"/>
<attribute_layout NAME_WIDTH="99" VALUE_WIDTH="99"/>
<attribute NAME="Time Complexity" VALUE="n"/>
<attribute NAME="Space Complexity" VALUE="1"/>
</node>
</node>
<node CREATED="1359989062389" ID="ID_841731708" MODIFIED="1359989532679" TEXT="Graph Traversal Algorithms">
<node CREATED="1359989086389" ID="ID_543281721" MODIFIED="1359989139836">
<richcontent TYPE="NODE"><html>
  <head>
    
  </head>
  <body>
    <p>
      <b>Depth-first search</b>
    </p>
    <p>
      - Visits child nodes before siblings
    </p>
    <p>
      - Implemented using stack or call stack/recusion
    </p>
  </body>
</html></richcontent>
</node>
<node CREATED="1359989171441" ID="ID_1831311731" MODIFIED="1359989231057">
<richcontent TYPE="NODE"><html>
  <head>
    
  </head>
  <body>
    <p>
      <b>Breadth-first search</b>
    </p>
    <p>
      - Visits nodes in the same level before child nodes
    </p>
    <p>
      - Implemented using queue
    </p>
  </body>
</html></richcontent>
</node>
<node CREATED="1359989536470" ID="ID_1742925589" MODIFIED="1359990092726">
<richcontent TYPE="NODE"><html>
  <head>
    
  </head>
  <body>
    <p>
      Minimum spanning tree
    </p>
    <p>
      Find subgraph that is a tree and connects all the vertices
    </p>
  </body>
</html></richcontent>
<node CREATED="1359989810205" ID="ID_1970112034" MODIFIED="1359989819549">
<richcontent TYPE="NODE"><html>
  <head>
    
  </head>
  <body>
    <p>
      <b>Kruskal's algorithm</b>
    </p>
  </body>
</html></richcontent>
</node>
<node CREATED="1359989928515" ID="ID_1418563441" MODIFIED="1359989938710">
<richcontent TYPE="NODE"><html>
  <head>
    
  </head>
  <body>
    <p>
      <b>Prim's algorithm</b>
    </p>
  </body>
</html></richcontent>
</node>
</node>
<node CREATED="1359989761206" ID="ID_25276127" MODIFIED="1359990097750">
<richcontent TYPE="NODE"><html>
  <head>
    
  </head>
  <body>
    <p>
      Shortest path problem
    </p>
  </body>
</html></richcontent>
<node CREATED="1359989259176" ID="ID_1561952951" MODIFIED="1359990069857">
<richcontent TYPE="NODE"><html>
  <head>
    
  </head>
  <body>
    <p>
      <b>Dijkstra's algorithm </b>
    </p>
    <p>
      - Works only with positive edge values
    </p>
  </body>
</html></richcontent>
</node>
<node CREATED="1359990020155" ID="ID_1882903451" MODIFIED="1359990032495">
<richcontent TYPE="NODE"><html>
  <head>
    
  </head>
  <body>
    <p>
      <b>Bellman&#8211;Ford algorithm</b>
    </p>
  </body>
</html></richcontent>
</node>
<node CREATED="1362112341492" ID="ID_1204144578" MODIFIED="1362112357919">
<richcontent TYPE="NODE"><html>
  <head>
    
  </head>
  <body>
    <p>
      <b>A* algorithm</b>
    </p>
  </body>
</html>
</richcontent>
<font NAME="SansSerif" SIZE="12"/>
</node>
</node>
</node>
</node>
<node CREATED="1359973524387" ID="ID_863161291" MODIFIED="1359973527585" POSITION="left" TEXT="Data Structures">
<node CREATED="1359973533216" ID="ID_650802495" MODIFIED="1359989743999">
<richcontent TYPE="NODE"><html>
  <head>
    
  </head>
  <body>
    <p>
      <b>Trees</b>
    </p>
    <p>
      Connected graph without cycles is a tree
    </p>
  </body>
</html></richcontent>
<node CREATED="1359986287149" ID="ID_757854426" MODIFIED="1359987988183">
<richcontent TYPE="NODE"><html>
  <head>
    
  </head>
  <body>
    <p>
      <b>B-Tree</b>
    </p>
    <p>
      - Tree with multiple children per node
    </p>
    <p>
      - Every node contains key and data
    </p>
  </body>
</html></richcontent>
<attribute_layout NAME_WIDTH="103" VALUE_WIDTH="103"/>
<attribute NAME="Space Complexity" VALUE="n"/>
<attribute NAME="Search Complexity" VALUE="log n"/>
<attribute NAME="Insert Complexity" VALUE="log n"/>
<attribute NAME="Delete Complexity" VALUE="log n"/>
</node>
<node CREATED="1359973552171" ID="ID_340563275" MODIFIED="1359988273488">
<richcontent TYPE="NODE"><html>
  <head>
    
  </head>
  <body>
    <p>
      <b>B+ Tree </b>
    </p>
    <p>
      - Only leaves nodes contain data
    </p>
    <p>
      - Leaves are linked together for sequential access (range query)
    </p>
    <p>
      - Cache friendly (block size can be considered, e.g. each branch can be 4kb)
    </p>
    <p>
      <img src="images/bplustree.png" />
    </p>
  </body>
</html></richcontent>
<attribute_layout NAME_WIDTH="103" VALUE_WIDTH="103"/>
<attribute NAME="Space Complexity" VALUE="n"/>
<attribute NAME="Search Complexity" VALUE="log n"/>
<attribute NAME="Insert Complexity" VALUE="log n"/>
<attribute NAME="Delete Complexity" VALUE="log n"/>
</node>
<node CREATED="1359973647494" ID="ID_1292887056" MODIFIED="1359973649647" TEXT="Binary Tree">
<node CREATED="1359973889670" ID="ID_1625189373" MODIFIED="1359988352212">
<richcontent TYPE="NODE"><html>
  <head>
    
  </head>
  <body>
    <p>
      <b>Binary Search Tree</b>
    </p>
    <p>
      <img src="images/bst.png" />
    </p>
  </body>
</html></richcontent>
<attribute_layout NAME_WIDTH="103" VALUE_WIDTH="103"/>
<attribute NAME="Space Complexity" VALUE="n"/>
<attribute NAME="Search Complexity" VALUE="log n"/>
<attribute NAME="Insert Complexity" VALUE="log n"/>
<attribute NAME="Delete Complexity" VALUE="log n"/>
</node>
<node CREATED="1359973758817" ID="ID_1065599689" MODIFIED="1359974917333">
<richcontent TYPE="NODE"><html>
  <head>
    
  </head>
  <body>
    <p>
      <b>Red-Black Tree&#160;(Self-Balancing)</b>
    </p>
    <p>
      <img src="images/red_black_tree.png" />
    </p>
  </body>
</html></richcontent>
<font NAME="SansSerif" SIZE="12"/>
</node>
<node CREATED="1359973773309" ID="ID_34137040" MODIFIED="1359974923760" TEXT="AVL Tree (Self-Balancing)">
<font BOLD="true" NAME="SansSerif" SIZE="12"/>
</node>
</node>
<node CREATED="1359974517609" ID="ID_801345266" MODIFIED="1359988932183">
<richcontent TYPE="NODE"><html>
  <head>
    
  </head>
  <body>
    <p>
      <b>Heap (max heap): </b>
    </p>
    <p>
      - Find min/max in O(1)
    </p>
    <p>
      - Remove min in O(log n)
    </p>
    <p>
      <img src="images/heap.png" />
    </p>
  </body>
</html></richcontent>
</node>
</node>
<node CREATED="1359975058848" ID="ID_1789638744" MODIFIED="1359975672902" TEXT="Hash Table">
<arrowlink DESTINATION="ID_1789638744" ENDARROW="Default" ENDINCLINATION="0;0;" ID="Arrow_ID_57485684" STARTARROW="None" STARTINCLINATION="0;0;"/>
<node CREATED="1359975098494" ID="ID_54447881" MODIFIED="1359975100553" TEXT="Collision">
<node CREATED="1359975279095" ID="ID_701965553" MODIFIED="1359975290109">
<richcontent TYPE="NODE"><html>
  <head>
    
  </head>
  <body>
    <p>
      <b>Chaining</b>&#160;(Linked-List)
    </p>
  </body>
</html></richcontent>
</node>
<node CREATED="1359975195182" ID="ID_1347790849" MODIFIED="1359975253503">
<richcontent TYPE="NODE"><html>
  <head>
    
  </head>
  <body>
    <p>
      <b>Open Addressing</b>&#160;(finding empty bucket)
    </p>
    <p>
      - Linear probing
    </p>
    <p>
      - Quadratic probing
    </p>
    <p>
      - Double Hashing
    </p>
  </body>
</html></richcontent>
</node>
</node>
<node CREATED="1359975105888" ID="ID_45290526" MODIFIED="1359975111949" TEXT="Resizing">
<node CREATED="1359975348197" ID="ID_1303920138" MODIFIED="1359991461570">
<richcontent TYPE="NODE"><html>
  <head>
    
  </head>
  <body>
    <p>
      Copy all elements
    </p>
  </body>
</html></richcontent>
<font BOLD="true" NAME="SansSerif" SIZE="12"/>
</node>
<node CREATED="1359975357105" ID="ID_1175673363" MODIFIED="1359975393446">
<richcontent TYPE="NODE"><html>
  <head>
    
  </head>
  <body>
    <p>
      <b>Incremental Resizing </b>
    </p>
    <p>
      - New Hash Table
    </p>
    <p>
      - Copy step-by-step
    </p>
    <p>
      - Check both tables till finished
    </p>
  </body>
</html></richcontent>
</node>
<node CREATED="1359975494162" ID="ID_449159011" MODIFIED="1359975645352">
<richcontent TYPE="NODE"><html>
  <head>
    
  </head>
  <body>
    <p>
      <b>Consistent Hashing</b>
    </p>
    <p>
      - Map each object to a point on the edge of a circle
    </p>
    <p>
      - Machine or Buckets are distributed across the circle
    </p>
    <p>
      - Find location in cicle and walk around till the next machine / bucket
    </p>
  </body>
</html></richcontent>
</node>
</node>
<node CREATED="1359975115225" ID="ID_718977607" MODIFIED="1359975665663" TEXT="Distributed Hash Table"/>
</node>
<node CREATED="1359988993106" ID="ID_308638144" MODIFIED="1359988994697" TEXT="Graphs">
<node CREATED="1359989638252" ID="ID_1336545434" MODIFIED="1359989641669" TEXT="directed Graph"/>
<node CREATED="1359989647456" ID="ID_552429750" MODIFIED="1359989650685" TEXT="undirected Graph"/>
</node>
</node>
</node>
</map>
