using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Taxcollector
{
	// Token: 0x020000C1 RID: 193
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class TaxCollectorRemovedEvent : IMessage<TaxCollectorRemovedEvent>, IMessage, IEquatable<TaxCollectorRemovedEvent>, IDeepCloneable<TaxCollectorRemovedEvent>, IBufferMessage
	{
		// Token: 0x17000175 RID: 373
		// (get) Token: 0x0600088F RID: 2191 RVA: 0x00191174 File Offset: 0x0018F374
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<TaxCollectorRemovedEvent> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17000176 RID: 374
		// (get) Token: 0x06000890 RID: 2192 RVA: 0x00191184 File Offset: 0x0018F384
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

		// Token: 0x17000177 RID: 375
		// (get) Token: 0x06000891 RID: 2193 RVA: 0x00191194 File Offset: 0x0018F394
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

		// Token: 0x06000892 RID: 2194 RVA: 0x001911A4 File Offset: 0x0018F3A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public TaxCollectorRemovedEvent()
		{
		}

		// Token: 0x06000893 RID: 2195 RVA: 0x001911B4 File Offset: 0x0018F3B4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public TaxCollectorRemovedEvent(TaxCollectorRemovedEvent other)
		{
		}

		// Token: 0x06000894 RID: 2196 RVA: 0x001911C4 File Offset: 0x0018F3C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public TaxCollectorRemovedEvent Clone()
		{
			return null;
		}

		// Token: 0x17000178 RID: 376
		// (get) Token: 0x06000895 RID: 2197 RVA: 0x001911D4 File Offset: 0x0018F3D4
		// (set) Token: 0x06000896 RID: 2198 RVA: 0x001911E4 File Offset: 0x0018F3E4
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

		// Token: 0x06000897 RID: 2199 RVA: 0x001911F4 File Offset: 0x0018F3F4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06000898 RID: 2200 RVA: 0x00191204 File Offset: 0x0018F404
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(TaxCollectorRemovedEvent other)
		{
			return true;
		}

		// Token: 0x06000899 RID: 2201 RVA: 0x00191214 File Offset: 0x0018F414
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x0600089A RID: 2202 RVA: 0x00191224 File Offset: 0x0018F424
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x0600089B RID: 2203 RVA: 0x00191234 File Offset: 0x0018F434
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x0600089C RID: 2204 RVA: 0x00191244 File Offset: 0x0018F444
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x0600089D RID: 2205 RVA: 0x00191254 File Offset: 0x0018F454
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x0600089E RID: 2206 RVA: 0x00191264 File Offset: 0x0018F464
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(TaxCollectorRemovedEvent other)
		{
		}

		// Token: 0x0600089F RID: 2207 RVA: 0x00191274 File Offset: 0x0018F474
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x060008A0 RID: 2208 RVA: 0x00191284 File Offset: 0x0018F484
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x060008A1 RID: 2209 RVA: 0x00191294 File Offset: 0x0018F494
		[MethodImpl(MethodImplOptions.NoInlining)]
		static TaxCollectorRemovedEvent()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 1;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				default:
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 4;
					break;
				case 1:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_3c7989f4a2374d0d90bdba8f296a38e1 != 0)
					{
						num2 = 0;
					}
					break;
				case 2:
					TaxCollectorRemovedEvent._parser = new MessageParser<TaxCollectorRemovedEvent>(() => null);
					num2 = 3;
					break;
				case 3:
					return;
				case 4:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_de04fdfebdbd4a719a239c73a4c6f026 != 0)
					{
						num2 = 2;
					}
					break;
				}
			}
		}

		// Token: 0x060008A2 RID: 2210 RVA: 0x00191360 File Offset: 0x0018F560
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool oVoSLSOkdVf9YOSMpkRB()
		{
			return true;
		}

		// Token: 0x060008A3 RID: 2211 RVA: 0x00191368 File Offset: 0x0018F568
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static TaxCollectorRemovedEvent MkEUgwOk98fiB3xUrELt()
		{
			return null;
		}

		// Token: 0x04000322 RID: 802
		private static readonly MessageParser<TaxCollectorRemovedEvent> _parser;

		// Token: 0x04000323 RID: 803
		private UnknownFieldSet _unknownFields;

		// Token: 0x04000324 RID: 804
		public const int TaxCollectorUidFieldNumber = 1;

		// Token: 0x04000325 RID: 805
		private string taxCollectorUid_;

		// Token: 0x04000326 RID: 806
		internal static TaxCollectorRemovedEvent lHH0L0Oks50rS3nMQd3G;
	}
}
