using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Taxcollector
{
	// Token: 0x020000AD RID: 173
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class TaxCollectorOrderedSpellRemoveRequest : IMessage<TaxCollectorOrderedSpellRemoveRequest>, IMessage, IEquatable<TaxCollectorOrderedSpellRemoveRequest>, IDeepCloneable<TaxCollectorOrderedSpellRemoveRequest>, IBufferMessage
	{
		// Token: 0x17000145 RID: 325
		// (get) Token: 0x0600077D RID: 1917 RVA: 0x0018FB98 File Offset: 0x0018DD98
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<TaxCollectorOrderedSpellRemoveRequest> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17000146 RID: 326
		// (get) Token: 0x0600077E RID: 1918 RVA: 0x0018FBA8 File Offset: 0x0018DDA8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17000147 RID: 327
		// (get) Token: 0x0600077F RID: 1919 RVA: 0x0018FBB8 File Offset: 0x0018DDB8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x06000780 RID: 1920 RVA: 0x0018FBC8 File Offset: 0x0018DDC8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public TaxCollectorOrderedSpellRemoveRequest()
		{
		}

		// Token: 0x06000781 RID: 1921 RVA: 0x0018FBD8 File Offset: 0x0018DDD8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public TaxCollectorOrderedSpellRemoveRequest(TaxCollectorOrderedSpellRemoveRequest other)
		{
		}

		// Token: 0x06000782 RID: 1922 RVA: 0x0018FBE8 File Offset: 0x0018DDE8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public TaxCollectorOrderedSpellRemoveRequest Clone()
		{
			return null;
		}

		// Token: 0x17000148 RID: 328
		// (get) Token: 0x06000783 RID: 1923 RVA: 0x0018FBF8 File Offset: 0x0018DDF8
		// (set) Token: 0x06000784 RID: 1924 RVA: 0x0018FC08 File Offset: 0x0018DE08
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string TaxCollectorUid
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
			}
		}

		// Token: 0x17000149 RID: 329
		// (get) Token: 0x06000785 RID: 1925 RVA: 0x0018FC18 File Offset: 0x0018DE18
		// (set) Token: 0x06000786 RID: 1926 RVA: 0x0018FC28 File Offset: 0x0018DE28
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int SlotId
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

		// Token: 0x06000787 RID: 1927 RVA: 0x0018FC38 File Offset: 0x0018DE38
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06000788 RID: 1928 RVA: 0x0018FC48 File Offset: 0x0018DE48
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(TaxCollectorOrderedSpellRemoveRequest other)
		{
			return true;
		}

		// Token: 0x06000789 RID: 1929 RVA: 0x0018FC58 File Offset: 0x0018DE58
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x0600078A RID: 1930 RVA: 0x0018FC68 File Offset: 0x0018DE68
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x0600078B RID: 1931 RVA: 0x0018FC78 File Offset: 0x0018DE78
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x0600078C RID: 1932 RVA: 0x0018FC88 File Offset: 0x0018DE88
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x0600078D RID: 1933 RVA: 0x0018FC98 File Offset: 0x0018DE98
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x0600078E RID: 1934 RVA: 0x0018FCA8 File Offset: 0x0018DEA8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(TaxCollectorOrderedSpellRemoveRequest other)
		{
		}

		// Token: 0x0600078F RID: 1935 RVA: 0x0018FCB8 File Offset: 0x0018DEB8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06000790 RID: 1936 RVA: 0x0018FCC8 File Offset: 0x0018DEC8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06000791 RID: 1937 RVA: 0x0018FCD8 File Offset: 0x0018DED8
		[MethodImpl(MethodImplOptions.NoInlining)]
		static TaxCollectorOrderedSpellRemoveRequest()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 2;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				case 1:
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_ead98ae52f7d4114bccb31c3ab7f1ef3 != 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 2:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_bd29ff3240cf44f4922b607ebfc502c7 != 0)
					{
						num2 = 1;
						continue;
					}
					continue;
				case 3:
					return;
				case 4:
					TaxCollectorOrderedSpellRemoveRequest._parser = new MessageParser<TaxCollectorOrderedSpellRemoveRequest>(() => null);
					num2 = 3;
					continue;
				}
				UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
				num2 = 4;
			}
		}

		// Token: 0x06000792 RID: 1938 RVA: 0x0018FDA4 File Offset: 0x0018DFA4
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool ghYtbWOIQKFLwhJpxcOj()
		{
			return true;
		}

		// Token: 0x06000793 RID: 1939 RVA: 0x0018FDAC File Offset: 0x0018DFAC
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static TaxCollectorOrderedSpellRemoveRequest wblR4POI7YZG3pyhjP7N()
		{
			return null;
		}

		// Token: 0x040002CA RID: 714
		private static readonly MessageParser<TaxCollectorOrderedSpellRemoveRequest> _parser;

		// Token: 0x040002CB RID: 715
		private UnknownFieldSet _unknownFields;

		// Token: 0x040002CC RID: 716
		public const int TaxCollectorUidFieldNumber = 1;

		// Token: 0x040002CD RID: 717
		private string taxCollectorUid_;

		// Token: 0x040002CE RID: 718
		public const int SlotIdFieldNumber = 2;

		// Token: 0x040002CF RID: 719
		private int slotId_;

		// Token: 0x040002D0 RID: 720
		internal static TaxCollectorOrderedSpellRemoveRequest BI1bhjOIwXUcwuJjXBCV;
	}
}
