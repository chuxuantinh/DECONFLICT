
public static bool CheckforDuplicates(string[] array)
        {
            var duplicates = array
             .GroupBy(p => p)
             .Where(g => g.Count() > 1)
             .Select(g => g.Key);
            if (duplicates.Count() > 0)
            {
                Console.WriteLine("Có phần tử trùng");
            }

            return (duplicates.Count() > 0);

        }

Console.WriteLine("...................Deconflict rule begin.....................");

            List<string> list_ac_of_rule_input = new List<string>();
            
            list_ac_of_rule_input.Add(command.Action); 
            string items_input = string.Join(",", list_ac_of_rule_input);
            Console.WriteLine("{" + items_input + "}");
            int count_item_input = list_ac_of_rule_input.Count();
            Console.WriteLine(count_item_input);

            List<string> list_ac_of_rule_i1 = new List<string>();
            foreach (var p in accessControlPolicies_store)
            { list_ac_of_rule_i1.Add(p.Action); }
            string items1 = string.Join(",", list_ac_of_rule_i1);
            Console.WriteLine("{" +items1 + "}");
            int count_item = list_ac_of_rule_i1.Count();
            Console.WriteLine(count_item);

            // Deconflict AD intersection

            List<string> list_collection_re = new List<string>();
            foreach (var co in accessControlPolicies_store)
            {
                list_collection_re.Add(co.CollectionName);
                string col = string.Join(",", list_collection_re);
            }

            List<string> common = list_ac_of_rule_input.Intersect(list_ac_of_rule_i1).ToList();
            string items3 = string.Join(",", common);
            Console.WriteLine(items3);
            //Common action CA

            //Tim cac policy co conflict o tren , ghi nhan vao list
            List<string> list_po_conflict_distinct = list_policy_conflict.Distinct().ToList();
            string list_po_conflict = string.Join(",", list_po_conflict_distinct);
            Console.Write("Danh sach policy co kha nang trung:");
            Console.WriteLine(list_po_conflict);
            //xuong phan nay moi load rule cua cac policy nay de giai quyet, hoac call function