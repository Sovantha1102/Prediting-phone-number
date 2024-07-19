Public Class Formgame
    Public snum As String
    Public num As Integer
    Public result As Integer
    Private Sub txtNumber_TextChanged(sender As Object, e As EventArgs) Handles txtNumber.TextChanged
        If txtNumber.Text.Length = 9 Then
            snum = txtNumber.Text.Substring(3, 6)
            num = CType(snum, Integer)
            'MsgBox(num)
        ElseIf txtNumber.Text.Length = 10 Then
            snum = txtNumber.Text.Substring(4, 6)
            num = CType(snum, Integer)
            'MsgBox(num)
        End If
    End Sub
    Private Sub btnCal_Click(sender As Object, e As EventArgs) Handles btnCal.Click
        result = num Mod 80
        'MsgBox(result)
        showrenum()
        ShowResult()
    End Sub
    Sub ShowResult()
        Select Case result
            Case 1
                TxtResult.Text = "1.ល្អណាស់ : រីកចំរើនល្អអាចទទួលបានជ័យជំនះ"
            Case 2
                TxtResult.Text = "2.ធម្មតា : មានលាភមានបង់មិនទទួលផលអ្វីទេ"
            Case 3
                TxtResult.Text = "3.ល្អណាស់ : មានភាពរីកចំរើនអ្វីៗអាចសំរេចបានដូចបំណង"
            Case 4
                TxtResult.Text = "4.អាក្រក់ : ផ្លូវអនាគតមានឧបសគ្គច្រើនលំបាកវេទនា"
            Case 5
                TxtResult.Text = "5.ល្អណាស់ : រកស៊ីមានបានទទួលបានទាំងកិត្តិយសទាំងផលប្រយោជន៍"
            Case 6
                TxtResult.Text = "6.ល្អណាស់ : មានសំណាងច្រើនអាចទទួលបានគុណសម្បត្តិធំ"
            Case 7
                TxtResult.Text = "7.ល្អ : មានចិត្តអត់ធ្មត់ពិតជាអាចទទួលបានជោគជ័យដ៏ធំ"
            Case 8
                TxtResult.Text = "8.ល្អ : អាចមានឳកាសទទួលបានជោគជ័យ"
            Case 9
                TxtResult.Text = "9.អាក្រក់ : ឯកកោរ គ្មានអ្នកជួយពិបាកទទួលទ្រព្យមកវិញ"
            Case 10
                TxtResult.Text = "10.អាក្រក់ : ខាតបង់ទឹកចិត្តនិងកម្លាំងទទេ ខិតខំដោយឥតបានផល"
            Case 11
                TxtResult.Text = "11.ល្អ : មានលំនឹងល្អអ្នកដទៃស្ងើចសរសើរ"
            Case 12
                TxtResult.Text = "12.អាក្រក់ : ទន់ខ្សោយធ្វើអ្វីក៏មិនបានសំរេចដែរ"
            Case 13
                TxtResult.Text = "13.ល្អណាស់ : មានសំណាង់ល្អក្តីសង្ឃឹមច្រើន"
            Case 14
                TxtResult.Text = "14.ធម្មតា : ជ័យជំនះ ឬបរាជ័យពឹងផ្អែកលើការតាំងចិត្តរបស់ខ្លួន"
            Case 15
                TxtResult.Text = "15.ល្អ : ជ័យជំនះច្រើនមានការរីកចំរើន"
            Case 16
                TxtResult.Text = "16.ល្អណាស់ : អាចសំរេចកិច្ចការធំបានទទួលទាំងកិត្តិយសទាំងផលប្រយោជន៍"
            Case 17
                TxtResult.Text = "17.ល្អ : មានអ្នកធំជួយអាចទទួលបានជោគជ័យ"
            Case 18
                TxtResult.Text = "18.ល្អ : មានភាពរីកចចម្រើននឹងបានសំរេចដូចបំណង"
            Case 19
                TxtResult.Text = "19.អាក្រក់ : មានទំនាស់ច្រើនមានឧបសគ្គគ្រប់ជំពូក"
            Case 20
                TxtResult.Text = "20.អាក្រក់ : ឧបសគ្គច្រើនឈឺច្រើនពិបាកចិត្តច្រើន"
            Case 21
                TxtResult.Text = "21.ល្អ : ធ្វើការល្អិតល្អន់មានបា្រជ្ញា"
            Case 22
                TxtResult.Text = "22.អាក្រក់ណាស់: ខាតបង់លាភធ្វើអ្វីក៏មិនបានសំរេចដូចបំណងដែរ"
            Case 23
                TxtResult.Text = "23.ល្អណាស់ : កិត្តិយសល្អសំរេចកិច្ចការធំបាន"
            Case 24
                TxtResult.Text = "24.ល្អ : ពឹងផ្អែកលើសមត្តភាពផ្ទាល់ខ្លួនអាចសម្រេចកិច្ចការបាន"
            Case 25
                TxtResult.Text = "25.ល្អណាស់ : មានសំណាងល្អមានគេជួយ"
            Case 26
                TxtResult.Text = "26.អាក្រក់ណាស់: មានឧបសគ្គច្រើន"
            Case 27
                TxtResult.Text = "27.ល្អ : អាចមានលាភសំណាងនិងជ័យជំនះ"
            Case 28
                TxtResult.Text = "28.ល្អណាស់ : រាសីទ្បើងខ្ពស់រកស៊ីមានបាន"
            Case 29
                TxtResult.Text = "29.អាក្រក់ : សំណាងល្អនិងអាក្រក់ កើតមានទ្បើងព្រមគ្នា"
            Case 30
                TxtResult.Text = "30.ល្អណាស់ : ទទួលបាននូវលាភសំណាងនិងកិតិ្តយស"
            Case 31
                TxtResult.Text = "31.ល្អណាស់ : មានសំណាងអាចទទួលជោគជ័យ"
            Case 32
                TxtResult.Text = "32.ល្អ : មានប្រាជ្ញាឈ្លាសវៃមានភាពរីកចម្រើនច្រើន"
            Case 33
                TxtResult.Text = "33អាក្រក់ណាស់ : ជួបឧបសគ្គមិនចេះអស់ពិបាកនឹងទទួលបានជោគជ័យ"
            Case 34
                TxtResult.Text = "34.ធម្មតា : ត្រូវមានលំនឹងចិត្តកុំលោភលន់"
            Case 35
                TxtResult.Text = "35.អាក្រក់ : ឧបសគ្គច្រើនតែជួបភាពលំបាក និងក្រខ្សត់"
            Case 36
                TxtResult.Text = "36.ល្អ : ឧបសគ្គអាចក្លាយជាសំណាងធ្វើអ្វីៗអាចបានដូចបំណង"
            Case 37
                TxtResult.Text = "37.ធម្មតា : អាចទទួលបាននូវកិត្តិយសតែពិបាកទទួលនូវលាភសំណាង"
            Case 38
                TxtResult.Text = "38.ល្អណាស់ : អនាគតភ្លឺស្វាងត្រចះត្រចង់"
            Case 39
                TxtResult.Text = "39.ធម្មតា : មានសំណាងឬឧបសគ្គមានមិនទៀង"
            Case 40
                TxtResult.Text = "40.ល្អណាស់: មានសំណាងល្អអនាគតល្អហើយភ្លឺស្វាង ត្រចះត្រចង់"
            Case 41
                TxtResult.Text = "41.អាក្រក់ : ការរកស៊ីត្រូវខាតបង់"
            Case 42
                TxtResult.Text = "42.ល្អ : បើមានចិត្តអត់ធ្មត់សំណាងអាក្រក់ អាចក្លាយជាមានលាភ"
            Case 43
                TxtResult.Text = "43.អាក្រក់ : រឿងអ្វីៗពិបាកសម្រេចដូចបំណងប្រាថ្នា"
            Case 44
                TxtResult.Text = "44.ល្អ : មានសំណាងមានភាពរីកចម្រើន"
            Case 45
                TxtResult.Text = "45.ល្អណាស់ : ជួបឧបសគ្គ មិនចេះអស់"
            Case 46
                TxtResult.Text = "46.ល្អណាស់ : មានគេតាមជួយថែរក្សា អាចប្រកបមុខជំនួញបាន"
            Case 47
                TxtResult.Text = "47.ល្អណាស់: មានទាំងកិត្តិយសមានទាំងទ្រព្យសម្បត្តិ"
            Case 48
                TxtResult.Text = "48.ធម្មតា : មានឧបសគ្គហើយក៏មានសំណាងដែរ"
            Case 49
                TxtResult.Text = "49.ធម្មតា : មានឧបសគ្គហើយក៏មានសំណាងដែរ"
            Case 50
                TxtResult.Text = "50.ធម្មតា : លាភសំណាងនិងឧបសគ្គគឺមកមិនទៀង"
            Case 51
                TxtResult.Text = "51.ល្អ : ខិតខំនិងទទួលបានជោគជ័យ"
            Case 52
                TxtResult.Text = "52.អាក្រក់ : ពេលបានលាភសំណាងនិងមានឧបសគ្គតាមមកពីក្រោយ"
            Case 53
                TxtResult.Text = "53.ធម្មតា : ខិតខំប្រឹងប្រែងខ្លាំងតែទទួលបានលទ្ធផលតិចតួច"
            Case 54
                TxtResult.Text = "54.អាក្រក់ : ល្អតែសំបកក្រៅតែតាមការពិតមានឧបសគ្គ និងគ្រោះថ្នាក់"
            Case 55
                TxtResult.Text = "55.អាក្រក់ណាស់ : ជួបឧបសគ្គ មិនចេះអស់អាចមានគ្រោះថ្នាក់"
            Case 56
                TxtResult.Text = "56.ល្អ : ខិតខំប្រឹងប្រែងអាចកែប្រែនូវជោគវាសនា"
            Case 57
                TxtResult.Text = "57.ធម្មតា : មានឧបសគ្គច្រើន តែសំណាងល្អនឹងមកពីក្រោយ"
            Case 58
                TxtResult.Text = "58.អាក្រក់ : ពេលជួបនិងបញ្ហាចិត្តមិត្តនឹងនរពិបាកសំរេចចិត្ត"
            Case 59
                TxtResult.Text = "59.ធម្មតា : ចិត្តច្របូកច្របល់ពិបាកសំរេចចិត្ត"
            Case 60
                TxtResult.Text = "60.អាក្រក់ : ជួបឧបសគ្គច្រើន"
            Case 61
                TxtResult.Text = "61.អាក្រក់ : មានរឿងស្មុគស្មាញច្រើនពិបាកសំរេចអ្វីៗដែលបានប៉ងទុក"
            Case 62
                TxtResult.Text = "62.ល្អ : ខិតខំនិងទទួលបាននូវផលប្រយោជន៍"
            Case 63
                TxtResult.Text = "63.អាក្រក់ : ខឹងខំ តែគ្មានទទួលបានផលប្រយោជន៍អ្វីទ្បើយ"
            Case 64
                TxtResult.Text = "64.ល្អ : មានសំណាងល្អអាចប្រកបមុខជំនួយបានធំបាន"
            Case 65
                TxtResult.Text = "65.ធម្មតា : ល្អ តែខ្វះទំនុកចិត្តលើខ្លួនឯង"
            Case 66
                TxtResult.Text = "66.ល្អណាស់: ធ្វើអ្វីៗតែងបានសំរេចមាសប្រាក់ហូរចូលច្រើន"
            Case 67
                TxtResult.Text = "67.ល្អ : ប្រសិនបើអាចក្តាប់ជាប់នូវឳកាសល្អអាចទទួលបានជោគជំនះ"
            Case 68
                TxtResult.Text = "68.អាក្រក់ : ស្ថានភាពមិននឹងនរអាចចាញ់បោកគេជួបឧបសគ្គច្រើន"
            Case 69
                TxtResult.Text = "69.អាក្រក់ : រកស៊ីខាតបង់ជួបភាពច្របូកច្របល់និងឧបសគ្គ"
            Case 70
                TxtResult.Text = "70.ធម្មតា : សំណាងល្អឬអាក្រក់អាស្រ័យលើភាពក្លាហាន"
            Case 71
                TxtResult.Text = "71.អាក្រក់ : បានហើយតែប្រែជាបាត់បង់ទៅវិញពិបាកសំរេចតាមបំណងណាស់"
            Case 72
                TxtResult.Text = "72.ល្អ : មានសុភមង្គលនិងសំណាងល្អ"
            Case 73
                TxtResult.Text = "73.ធម្មតា : បើសិនជារុញរាពិបាកនិងទទួលជោគជំនះណាស់"
            Case 74
                TxtResult.Text = "74.ធម្មតា : មានសំណាងល្អណាស់ក៏មានសំណាងអក្រក់ដែរ"
            Case 75
                TxtResult.Text = "75.អាក្រក់ : ការងាររកស៊ីខាតបង់ឳកាស អស់ទ្រព្យសម្បត្តិ"
            Case 76
                TxtResult.Text = "76.ល្អ : ពិបាកមុនស្រណុកក្រោយ"
            Case 77
                TxtResult.Text = "77.ធម្មតា : មានលាភមានបង់មិនអាចស្តុកស្តម្ភ"
            Case 78
                TxtResult.Text = "78.ធម្មតា : អនាគតមិនសូវភ្លឺស្វាងទេហើយក៏មិនសូវមានទ្រព្យសម្បត្តិដែរ"
            Case 79
                TxtResult.Text = "79.អាក្រក់ : បានហើយតែប្រែជាខាតបង់ទៅវិញខិតខំឥតប្រយោជន៍"
            Case 80
                TxtResult.Text = "80.ល្អណាស់: អាចទទួលបានជោគជ័យច្រើន"
        End Select
    End Sub
    Private Sub btnClean_Click(sender As Object, e As EventArgs) Handles btnClean.Click
        txtNumber.Clear()
        TxtResult.Clear()

    End Sub
    Private Sub txtNumber_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNumber.KeyPress
        If Not Char.IsNumber(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) And Not e.KeyChar = Chr(Keys.Space) Then
            e.Handled = True
            MessageBox.Show("Only accept Number")
        End If
    End Sub
End Class
