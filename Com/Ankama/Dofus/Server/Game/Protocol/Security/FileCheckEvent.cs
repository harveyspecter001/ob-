using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Security
{
	// Token: 0x02000172 RID: 370
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class FileCheckEvent : IMessage<FileCheckEvent>, IMessage, IEquatable<FileCheckEvent>, IDeepCloneable<FileCheckEvent>, IBufferMessage
	{
		// Token: 0x170002FC RID: 764
		// (get) Token: 0x060010E8 RID: 4328 RVA: 0x0019F350 File Offset: 0x0019D550
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<FileCheckEvent> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x170002FD RID: 765
		// (get) Token: 0x060010E9 RID: 4329 RVA: 0x0019F360 File Offset: 0x0019D560
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

		// Token: 0x170002FE RID: 766
		// (get) Token: 0x060010EA RID: 4330 RVA: 0x0019F370 File Offset: 0x0019D570
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

		// Token: 0x060010EB RID: 4331 RVA: 0x0019F380 File Offset: 0x0019D580
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public FileCheckEvent()
		{
		}

		// Token: 0x060010EC RID: 4332 RVA: 0x0019F390 File Offset: 0x0019D590
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public FileCheckEvent(FileCheckEvent other)
		{
		}

		// Token: 0x060010ED RID: 4333 RVA: 0x0019F3A0 File Offset: 0x0019D5A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public FileCheckEvent Clone()
		{
			return null;
		}

		// Token: 0x170002FF RID: 767
		// (get) Token: 0x060010EE RID: 4334 RVA: 0x0019F3B0 File Offset: 0x0019D5B0
		// (set) Token: 0x060010EF RID: 4335 RVA: 0x0019F3C0 File Offset: 0x0019D5C0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public string FileName
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

		// Token: 0x17000300 RID: 768
		// (get) Token: 0x060010F0 RID: 4336 RVA: 0x0019F3D0 File Offset: 0x0019D5D0
		// (set) Token: 0x060010F1 RID: 4337 RVA: 0x0019F3E4 File Offset: 0x0019D5E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CheckType CheckType
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return (CheckType)null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
			}
		}

		// Token: 0x060010F2 RID: 4338 RVA: 0x0019F3F4 File Offset: 0x0019D5F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x060010F3 RID: 4339 RVA: 0x0019F404 File Offset: 0x0019D604
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(FileCheckEvent other)
		{
			return true;
		}

		// Token: 0x060010F4 RID: 4340 RVA: 0x0019F414 File Offset: 0x0019D614
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x060010F5 RID: 4341 RVA: 0x0019F424 File Offset: 0x0019D624
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x060010F6 RID: 4342 RVA: 0x0019F434 File Offset: 0x0019D634
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x060010F7 RID: 4343 RVA: 0x0019F444 File Offset: 0x0019D644
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x060010F8 RID: 4344 RVA: 0x0019F454 File Offset: 0x0019D654
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x060010F9 RID: 4345 RVA: 0x0019F464 File Offset: 0x0019D664
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(FileCheckEvent other)
		{
		}

		// Token: 0x060010FA RID: 4346 RVA: 0x0019F474 File Offset: 0x0019D674
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x060010FB RID: 4347 RVA: 0x0019F484 File Offset: 0x0019D684
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x060010FC RID: 4348 RVA: 0x0019F494 File Offset: 0x0019D694
		[MethodImpl(MethodImplOptions.NoInlining)]
		static FileCheckEvent()
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
					num2 = 1;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_84ebe06b6d224edaa67fb45e43afb5d8 == 0)
					{
						num2 = 4;
						continue;
					}
					continue;
				case 2:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 1;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_1837bd6484274412a963767d86a67356 != 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 3:
					return;
				case 4:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_8793adccb59548138145e36aa64d0b4b == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				}
				FileCheckEvent._parser = new MessageParser<FileCheckEvent>(() => null);
				num2 = 0;
				if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_5750350b4e81418bb3d8d7d0657de68b == 0)
				{
					num2 = 3;
				}
			}
		}

		// Token: 0x060010FD RID: 4349 RVA: 0x0019F58C File Offset: 0x0019D78C
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool kebg6GOvgXOquZmeNg4O()
		{
			return true;
		}

		// Token: 0x060010FE RID: 4350 RVA: 0x0019F594 File Offset: 0x0019D794
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static FileCheckEvent VQdHE5Ovs7IQnTm2qKHm()
		{
			return null;
		}

		// Token: 0x04000628 RID: 1576
		private static readonly MessageParser<FileCheckEvent> _parser;

		// Token: 0x04000629 RID: 1577
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400062A RID: 1578
		public const int FileNameFieldNumber = 1;

		// Token: 0x0400062B RID: 1579
		private string fileName_;

		// Token: 0x0400062C RID: 1580
		public const int CheckTypeFieldNumber = 2;

		// Token: 0x0400062D RID: 1581
		private CheckType checkType_;

		// Token: 0x0400062E RID: 1582
		private static FileCheckEvent k4JtaCOvGrWD8yfGAfUM;
	}
}
