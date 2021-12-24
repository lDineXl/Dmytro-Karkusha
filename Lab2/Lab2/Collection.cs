﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    class Collection : IEnumerable
    {
        #region Fields and propertys
        /// <summary>
        /// Private field list of students
        /// </summary>
        private List<Student> _students = new List<Student>();

        /// <summary>
        /// Readonly property that returns count students in list
        /// </summary>
        public int Count => _students.Count;

        #endregion

        #region Indexers
        /// <summary>
        /// Overload Indexer by name and surname
        /// </summary>
        /// <param name="surname">Surname</param>
        /// <param name="name">Name</param>
        /// <returns></returns>
        public Student this[string surname, string name]
        {
            get
            {
                var student = _students.FirstOrDefault(s => (s.Surname == surname && s.Name == name));
                return student;
            }
        }
        /// <summary>
        /// Overload Indexer by position
        /// </summary>
        /// <param name="position">Position in list</param>
        /// <returns></returns>
        public Student this[int position]
        {
            get
            {
                if (position < _students.Count)
                {
                    return _students[position];
                }
                return null;
            }
            set
            {
                if (position < _students.Count && position > -1)
                {
                    _students[position] = value;
                }
            }
        }
        #endregion

        #region Methods

        /// <summary>
        /// Method that add Student in the and of collection
        /// </summary>
        /// <param name="student">Student</param>
        public void Add(Student student)
        {
            if (student == null)
            {
                throw new ArgumentNullException(nameof(student), "Student is null");
            }
            _students.Add(student);
        }

        /// <summary>
        /// Method that remove student from collection
        /// </summary>
        /// <param name="surname">Surname</param>
        /// <param name="name">Name</param>
        public void Remove(string surname, string name)
        {
            if (string.IsNullOrWhiteSpace(surname))
            {
                throw new ArgumentNullException(nameof(surname), "Surname is null or white space");
            }

            if (string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentNullException(nameof(name), "Name is null or white space");
            }

            var student = _students.FirstOrDefault(s => (s.Surname == surname && s.Name == name));

            if (student != null)
            {
                _students.Remove(student);
            }
        }
        #endregion

        #region Implement of IEnumerable
        public IEnumerator<Student> GetEnumerator()
        {
            return _students.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return _students.GetEnumerator();
        }
        #endregion
    }
}
