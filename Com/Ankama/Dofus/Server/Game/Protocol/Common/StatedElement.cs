using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Common
{
	// Token: 0x02000A7B RID: 2683
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class StatedElement : IMessage<StatedElement>, IMessage, IEquatable<StatedElement>, IDeepCloneable<StatedElement>, IBufferMessage
	{
		// Token: 0x17001756 RID: 5974
		// (get) Token: 0x0600801C RID: 32796 RVA: 0x0025F758 File Offset: 0x0025D958
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageParser<StatedElement> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17001757 RID: 5975
		// (get) Token: 0x0600801D RID: 32797 RVA: 0x0025F768 File Offset: 0x0025D968
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17001758 RID: 5976
		// (get) Token: 0x0600801E RID: 32798 RVA: 0x0025F778 File Offset: 0x0025D978
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x0600801F RID: 32799 RVA: 0x0025F788 File Offset: 0x0025D988
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public StatedElement()
		{
		}

		// Token: 0x06008020 RID: 32800 RVA: 0x0025F798 File Offset: 0x0025D998
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public StatedElement(StatedElement other)
		{
		}

		// Token: 0x06008021 RID: 32801 RVA: 0x0025F7A8 File Offset: 0x0025D9A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public StatedElement Clone()
		{
			return null;
		}

		// Token: 0x17001759 RID: 5977
		// (get) Token: 0x06008022 RID: 32802 RVA: 0x0025F7B8 File Offset: 0x0025D9B8
		// (set) Token: 0x06008023 RID: 32803 RVA: 0x0025F7C8 File Offset: 0x0025D9C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ElementId
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return 0;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
			}
		}

		// Token: 0x1700175A RID: 5978
		// (get) Token: 0x06008024 RID: 32804 RVA: 0x0025F7D8 File Offset: 0x0025D9D8
		// (set) Token: 0x06008025 RID: 32805 RVA: 0x0025F7E8 File Offset: 0x0025D9E8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public int CellId
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return 0;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
			}
		}

		// Token: 0x1700175B RID: 5979
		// (get) Token: 0x06008026 RID: 32806 RVA: 0x0025F7F8 File Offset: 0x0025D9F8
		// (set) Token: 0x06008027 RID: 32807 RVA: 0x0025F808 File Offset: 0x0025DA08
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public int State
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return 0;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
			}
		}

		// Token: 0x1700175C RID: 5980
		// (get) Token: 0x06008028 RID: 32808 RVA: 0x0025F818 File Offset: 0x0025DA18
		// (set) Token: 0x06008029 RID: 32809 RVA: 0x0025F828 File Offset: 0x0025DA28
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public bool OnCurrentMap
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return true;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
			}
		}

		// Token: 0x0600802A RID: 32810 RVA: 0x0025F838 File Offset: 0x0025DA38
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x0600802B RID: 32811 RVA: 0x0025F848 File Offset: 0x0025DA48
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(StatedElement other)
		{
			return true;
		}

		// Token: 0x0600802C RID: 32812 RVA: 0x0025F858 File Offset: 0x0025DA58
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x0600802D RID: 32813 RVA: 0x0025F868 File Offset: 0x0025DA68
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x0600802E RID: 32814 RVA: 0x0025F878 File Offset: 0x0025DA78
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x0600802F RID: 32815 RVA: 0x0025F888 File Offset: 0x0025DA88
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06008030 RID: 32816 RVA: 0x0025F898 File Offset: 0x0025DA98
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06008031 RID: 32817 RVA: 0x0025F8A8 File Offset: 0x0025DAA8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(StatedElement other)
		{
		}

		// Token: 0x06008032 RID: 32818 RVA: 0x0025F8B8 File Offset: 0x0025DAB8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06008033 RID: 32819 RVA: 0x0025F8C8 File Offset: 0x0025DAC8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06008034 RID: 32820 RVA: 0x0025F8D8 File Offset: 0x0025DAD8
		[MethodImpl(MethodImplOptions.NoInlining)]
		static StatedElement()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 1;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				case 1:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_4ec51c76f8d943f08859e3c2be1f0d41 != 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 2:
					StatedElement._parser = new MessageParser<StatedElement>(() => null);
					num2 = 3;
					continue;
				case 3:
					return;
				case 4:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 2;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_7dffff2eb1b849cc96c1b1e17cd952bf == 0)
					{
						num2 = 2;
						continue;
					}
					continue;
				}
				AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
				num2 = 1;
				if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_3b820d51a0304d6b80583bcd6b858510 != 0)
				{
					num2 = 4;
				}
			}
		}

		// Token: 0x06008035 RID: 32821 RVA: 0x0025F9BC File Offset: 0x0025DBBC
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool Ea9YF2JgOcIxciD6WOyK()
		{
			return true;
		}

		// Token: 0x06008036 RID: 32822 RVA: 0x0025F9C4 File Offset: 0x0025DBC4
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static StatedElement HVietOJgJkpgZqTDjLCU()
		{
			return null;
		}

		// Token: 0x04002E75 RID: 11893
		private static readonly MessageParser<StatedElement> _parser;

		// Token: 0x04002E76 RID: 11894
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002E77 RID: 11895
		public const int ElementIdFieldNumber = 1;

		// Token: 0x04002E78 RID: 11896
		private int elementId_;

		// Token: 0x04002E79 RID: 11897
		public const int CellIdFieldNumber = 2;

		// Token: 0x04002E7A RID: 11898
		private int cellId_;

		// Token: 0x04002E7B RID: 11899
		public const int StateFieldNumber = 3;

		// Token: 0x04002E7C RID: 11900
		private int state_;

		// Token: 0x04002E7D RID: 11901
		public const int OnCurrentMapFieldNumber = 4;

		// Token: 0x04002E7E RID: 11902
		private bool onCurrentMap_;

		// Token: 0x04002E7F RID: 11903
		private static StatedElement pGHKHeJgRwt1fpBitZDD;
	}
}
