using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Com.Ankama.Dofus.Server.Game.Protocol.Common;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Job
{
	// Token: 0x020003C3 RID: 963
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class JobCrafterDirectoryEntryEvent : IMessage<JobCrafterDirectoryEntryEvent>, IMessage, IEquatable<JobCrafterDirectoryEntryEvent>, IDeepCloneable<JobCrafterDirectoryEntryEvent>, IBufferMessage
	{
		// Token: 0x1700080C RID: 2060
		// (get) Token: 0x06002D2F RID: 11567 RVA: 0x001CE1B8 File Offset: 0x001CC3B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<JobCrafterDirectoryEntryEvent> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x1700080D RID: 2061
		// (get) Token: 0x06002D30 RID: 11568 RVA: 0x001CE1C8 File Offset: 0x001CC3C8
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

		// Token: 0x1700080E RID: 2062
		// (get) Token: 0x06002D31 RID: 11569 RVA: 0x001CE1D8 File Offset: 0x001CC3D8
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

		// Token: 0x06002D32 RID: 11570 RVA: 0x001CE1E8 File Offset: 0x001CC3E8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public JobCrafterDirectoryEntryEvent()
		{
		}

		// Token: 0x06002D33 RID: 11571 RVA: 0x001CE1F8 File Offset: 0x001CC3F8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public JobCrafterDirectoryEntryEvent(JobCrafterDirectoryEntryEvent other)
		{
		}

		// Token: 0x06002D34 RID: 11572 RVA: 0x001CE208 File Offset: 0x001CC408
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public JobCrafterDirectoryEntryEvent Clone()
		{
			return null;
		}

		// Token: 0x1700080F RID: 2063
		// (get) Token: 0x06002D35 RID: 11573 RVA: 0x001CE218 File Offset: 0x001CC418
		// (set) Token: 0x06002D36 RID: 11574 RVA: 0x001CE228 File Offset: 0x001CC428
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public JobCrafterDirectoryPlayerInformation PlayerInformation
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

		// Token: 0x17000810 RID: 2064
		// (get) Token: 0x06002D37 RID: 11575 RVA: 0x001CE238 File Offset: 0x001CC438
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<JobCrafterDirectoryJobInformation> JobsInformation
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17000811 RID: 2065
		// (get) Token: 0x06002D38 RID: 11576 RVA: 0x001CE248 File Offset: 0x001CC448
		// (set) Token: 0x06002D39 RID: 11577 RVA: 0x001CE258 File Offset: 0x001CC458
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityLook Look
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

		// Token: 0x06002D3A RID: 11578 RVA: 0x001CE268 File Offset: 0x001CC468
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06002D3B RID: 11579 RVA: 0x001CE278 File Offset: 0x001CC478
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(JobCrafterDirectoryEntryEvent other)
		{
			return true;
		}

		// Token: 0x06002D3C RID: 11580 RVA: 0x001CE288 File Offset: 0x001CC488
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06002D3D RID: 11581 RVA: 0x001CE298 File Offset: 0x001CC498
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06002D3E RID: 11582 RVA: 0x001CE2A8 File Offset: 0x001CC4A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06002D3F RID: 11583 RVA: 0x001CE2B8 File Offset: 0x001CC4B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06002D40 RID: 11584 RVA: 0x001CE2C8 File Offset: 0x001CC4C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06002D41 RID: 11585 RVA: 0x001CE2D8 File Offset: 0x001CC4D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(JobCrafterDirectoryEntryEvent other)
		{
		}

		// Token: 0x06002D42 RID: 11586 RVA: 0x001CE2E8 File Offset: 0x001CC4E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06002D43 RID: 11587 RVA: 0x001CE2F8 File Offset: 0x001CC4F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06002D44 RID: 11588 RVA: 0x001CE308 File Offset: 0x001CC508
		[MethodImpl(MethodImplOptions.NoInlining)]
		static JobCrafterDirectoryEntryEvent()
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
					num2 = 2;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_fec71c40d9f5414bbcabd5eeb74db805 != 0)
					{
						num2 = 3;
						continue;
					}
					continue;
				case 2:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 1;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_2d2589a17466462b8f45c545634b0246 == 0)
					{
						num2 = 1;
						continue;
					}
					continue;
				case 3:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_8793adccb59548138145e36aa64d0b4b != 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 4:
					return;
				case 5:
					JobCrafterDirectoryEntryEvent._repeated_jobsInformation_codec = FieldCodec.ForMessage<JobCrafterDirectoryJobInformation>(18U, YTB3wXn7WoZ68UEhcE0p.XVInXhlssT(YTB3wXn7WoZ68UEhcE0p.Dq8n7hjXTim));
					num2 = 4;
					continue;
				}
				JobCrafterDirectoryEntryEvent._parser = new MessageParser<JobCrafterDirectoryEntryEvent>(() => null);
				num2 = 5;
			}
		}

		// Token: 0x06002D45 RID: 11589 RVA: 0x001CE410 File Offset: 0x001CC610
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool bFZ5D7OViIa9LMjGQPbk()
		{
			return true;
		}

		// Token: 0x06002D46 RID: 11590 RVA: 0x001CE418 File Offset: 0x001CC618
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static JobCrafterDirectoryEntryEvent tXp7UyOVP6oiv3SwvQCN()
		{
			return null;
		}

		// Token: 0x04000FDD RID: 4061
		private static readonly MessageParser<JobCrafterDirectoryEntryEvent> _parser;

		// Token: 0x04000FDE RID: 4062
		private UnknownFieldSet _unknownFields;

		// Token: 0x04000FDF RID: 4063
		public const int PlayerInformationFieldNumber = 1;

		// Token: 0x04000FE0 RID: 4064
		private JobCrafterDirectoryPlayerInformation playerInformation_;

		// Token: 0x04000FE1 RID: 4065
		public const int JobsInformationFieldNumber = 2;

		// Token: 0x04000FE2 RID: 4066
		private static readonly FieldCodec<JobCrafterDirectoryJobInformation> _repeated_jobsInformation_codec;

		// Token: 0x04000FE3 RID: 4067
		private readonly RepeatedField<JobCrafterDirectoryJobInformation> jobsInformation_;

		// Token: 0x04000FE4 RID: 4068
		public const int LookFieldNumber = 3;

		// Token: 0x04000FE5 RID: 4069
		private EntityLook look_;

		// Token: 0x04000FE6 RID: 4070
		private static JobCrafterDirectoryEntryEvent M5ejkAOVbly680B5jKJ8;
	}
}
