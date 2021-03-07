using BinarySearchTreeTask;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace BinarySearchTreeTests.tests
{
    [TestFixture]
    public abstract class BinaryTreeTests<TItem> where TItem : IComparable<TItem>
    {
        public abstract BinarySearchTree<TItem> CreateTree(IEnumerable<TItem> collection);
        public abstract BinarySearchTree<TItem> CreateTree(IEnumerable<TItem> collection, IComparer<TItem> comparer);
        public abstract BinarySearchTree<TItem> CreateTree(IComparer<TItem> comparer);

        public virtual void TestNodeSerialization(IEnumerable<TItem> collection, IComparer<TItem> comparer)
        {
            BinarySearchTree<TItem> tree = CreateTree(collection, comparer);
            XmlSerializer serializer = new XmlSerializer(typeof(Node<TItem>));
            Node<TItem> expected = new Node<TItem>(tree.Root);

            using(FileStream stream = File.Create("Serialized.xml"))
            {
                serializer.Serialize(stream, tree.Root);
            }

            Node<TItem> actual;
            using(FileStream stream = File.OpenRead("Serialized.xml"))
            {
                actual = (Node<TItem>)serializer.Deserialize(stream);
            }

            Assert.AreEqual(expected, actual);
        }

        public virtual void TestSerializationAndDeserialization_OneTree_SameTree(IEnumerable<TItem> collection, IComparer<TItem> comparer)
        {
            BinarySearchTree<TItem> expected = CreateTree(collection, comparer);

            IFormatter formatter = new BinaryFormatter();
            using(FileStream stream = File.Create("SerializedTree.bin"))
            {
                formatter.Serialize(stream, expected);
            }

            BinarySearchTree<TItem> actual;
            using (FileStream stream = File.OpenRead("SerializedTree.bin"))
            {
                actual = (BinarySearchTree<TItem>)formatter.Deserialize(stream);
            }

            Assert.AreEqual(expected, actual);
        }

        public virtual TItem TestGetRootValue(IEnumerable<TItem> values)
		{
			BinarySearchTree<TItem> tree = CreateTree(values);

			return tree.Root.data;
		}

        public virtual void TestCreation_EmptyTree_Success(IComparer<TItem> comparer)
        {
            BinarySearchTree<TItem> tree = CreateTree(comparer);

            Assert.IsTrue(tree.IsEmpty);
        }

        public virtual TItem TestCreationByTwoElements_Right_Success(IEnumerable<TItem> collection, IComparer<TItem> comparer)
        {
            BinarySearchTree<TItem> tree = CreateTree(collection, comparer);

            return tree.Root.rightChild.data;
        }

        public virtual TItem TestCreationByTwoElements_Left_Success(IEnumerable<TItem> collection, IComparer<TItem> comparer)
        {
            BinarySearchTree<TItem> tree = CreateTree(collection, comparer);

            return tree.Root.leftChild.data;
        }
 
        public virtual void TestCreationByThreeElements_LeftAndRight_Success(IEnumerable<TItem> collection, IComparer<TItem> comparer,
            TItem expectedX, TItem expectedY)
        {
            BinarySearchTree<TItem> tree = CreateTree(collection, comparer);

            TItem actualX = tree.Root.rightChild.data;
            TItem actualY = tree.Root.leftChild.data;


            Assert.AreEqual(expectedX, actualX);
            Assert.AreEqual(expectedY, actualY);
        }

        public virtual void TestCreationByThreeElements_TwoLeft_Success(IEnumerable<TItem> collection, IComparer<TItem> comparer,
            TItem expectedX, TItem expectedY)
        {
            BinarySearchTree<TItem> tree = CreateTree(collection, comparer);

            TItem actualX = tree.Root.leftChild.data;
            TItem actualY = tree.Root.leftChild.leftChild.data;


            Assert.AreEqual(expectedX, actualX);
            Assert.AreEqual(expectedY, actualY);
        }

        public virtual void TestCreationByThreeElements_TwoRight_Success(IEnumerable<TItem> collection, IComparer<TItem> comparer,
            TItem expectedX, TItem expectedY)
        {
            BinarySearchTree<TItem> tree = CreateTree(collection, comparer);

            TItem actualX = tree.Root.rightChild.data;
            TItem actualY = tree.Root.rightChild.rightChild.data;


            Assert.AreEqual(expectedX, actualX);
            Assert.AreEqual(expectedY, actualY);
        }

        public virtual TItem TestAdd_OneNewValue_Success(IComparer<TItem> comparer, TItem item)
        {
            BinarySearchTree<TItem> tree = CreateTree(comparer);

            tree.Add(item);

            return tree.Root.data;
        }

        public virtual TItem TestAddRange_RangeOfNewValues_Success(IEnumerable<TItem> collection, IComparer<TItem> comparer)
        {
            BinarySearchTree<TItem> tree = CreateTree(comparer);

            tree.AddRange(collection);

            return tree.Root.data;
        }

        public virtual TItem TestGetMin_ValuesRange_56(IEnumerable<TItem> collection, IComparer<TItem> comparer)
        {
            BinarySearchTree<TItem> tree = CreateTree(collection, comparer);

            return tree.GetMin().data;
        }

        public virtual TItem TestGetMax_ValuesRange_5(IEnumerable<TItem> collection, IComparer<TItem> comparer)
        {
            BinarySearchTree<TItem> tree = CreateTree(collection, comparer);

            return tree.GetMax().data;
        }

        public virtual void TestGetEnumerator_12345_12345(IEnumerable<TItem> collection, IComparer<TItem> comparer)
        {
            BinarySearchTree<TItem> tree = CreateTree(collection, comparer);
            List<TItem> sortedItems = new List<TItem>();
            TItem expected = tree.GetMax().data;

            foreach(TItem item in tree)
            {
                sortedItems.Add(item);
            }

            TItem actual = sortedItems.LastOrDefault();

            Assert.AreEqual(expected, actual);
        }

        public virtual void TestGetReversedEnumerator_5281397_9875321(IEnumerable<TItem> collection, IComparer<TItem> comparer)
        {
            BinarySearchTree<TItem> tree = CreateTree(collection, comparer);
            List<TItem> sortedItems = new List<TItem>();
            TItem expected = tree.GetMax().data;

            IEnumerator<TItem> enumerator = tree.GetReversedEnumerator();
            while (enumerator.MoveNext())
            {
                sortedItems.Add(enumerator.Current);
            }
            TItem actual = sortedItems.FirstOrDefault();

            Assert.AreEqual(expected, actual);
        }

        public virtual TItem TestFind_2_Success(IEnumerable<TItem> collection, IComparer<TItem> comparer, TItem itemToFind)
        {
            BinarySearchTree<TItem> tree = CreateTree(collection, comparer);

            return tree.Find(itemToFind).data;
        }
    
        public virtual TItem TestGetLeft_5281397_1(IEnumerable<TItem> collection, IComparer<TItem> comparer)
        {
            BinarySearchTree<TItem> tree = CreateTree(collection, comparer);

            return tree.GetLeft().data;
        }

        public virtual TItem TestGetRight_5281397_7(IEnumerable<TItem> collection, IComparer<TItem> comparer)
        {
            BinarySearchTree<TItem> tree = CreateTree(collection, comparer);

            return tree.GetRight().data;
        }

        public virtual void TestDeleteNode_Success(IEnumerable<TItem> collection, IComparer<TItem> comparer, 
            List<TItem> expected, TItem dataToDelete)
        {
            BinarySearchTree<TItem> tree = new RecursiveTree<TItem>(collection, comparer);

            tree.Remove(dataToDelete);
            List<TItem> actual = new List<TItem>();
            foreach (TItem data in tree)
            {
                actual.Add(data);
            }

            Assert.AreEqual(expected, actual);
        }
    }
}
