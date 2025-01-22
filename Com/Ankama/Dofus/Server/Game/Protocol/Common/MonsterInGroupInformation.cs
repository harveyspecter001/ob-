using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Common
{
	// Token: 0x02000B43 RID: 2883
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class MonsterInGroupInformation : IMessage<MonsterInGroupInformation>, IMessage, IEquatable<MonsterInGroupInformation>, IDeepCloneable<MonsterInGroupInformation>, IBufferMessage
	{
		// Token: 0x17001985 RID: 6533
		// (get) Token: 0x06008A04 RID: 35332 RVA: 0x00267E10 File Offset: 0x00266010
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<MonsterInGroupInformation> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17001986 RID: 6534
		// (get) Token: 0x06008A05 RID: 35333 RVA: 0x00267E20 File Offset: 0x00266020
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

		// Token: 0x17001987 RID: 6535
		// (get) Token: 0x06008A06 RID: 35334 RVA: 0x00267E30 File Offset: 0x00266030
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

		// Token: 0x06008A07 RID: 35335 RVA: 0x00267E40 File Offset: 0x00266040
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public MonsterInGroupInformation()
		{
		}

		// Token: 0x06008A08 RID: 35336 RVA: 0x00267E50 File Offset: 0x00266050
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public MonsterInGroupInformation(MonsterInGroupInformation other)
		{
		}

		// Token: 0x06008A09 RID: 35337 RVA: 0x00267E60 File Offset: 0x00266060
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public MonsterInGroupInformation Clone()
		{
			return null;
		}

		// Token: 0x17001988 RID: 6536
		// (get) Token: 0x06008A0A RID: 35338 RVA: 0x00267E70 File Offset: 0x00266070
		// (set) Token: 0x06008A0B RID: 35339 RVA: 0x00267E80 File Offset: 0x00266080
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Gid
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

		// Token: 0x17001989 RID: 6537
		// (get) Token: 0x06008A0C RID: 35340 RVA: 0x00267E90 File Offset: 0x00266090
		// (set) Token: 0x06008A0D RID: 35341 RVA: 0x00267EA0 File Offset: 0x002660A0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public int Grade
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

		// Token: 0x1700198A RID: 6538
		// (get) Token: 0x06008A0E RID: 35342 RVA: 0x00267EB0 File Offset: 0x002660B0
		// (set) Token: 0x06008A0F RID: 35343 RVA: 0x00267EC0 File Offset: 0x002660C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Level
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

		// Token: 0x1700198B RID: 6539
		// (get) Token: 0x06008A10 RID: 35344 RVA: 0x00267ED0 File Offset: 0x002660D0
		// (set) Token: 0x06008A11 RID: 35345 RVA: 0x00267EE0 File Offset: 0x002660E0
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

		// Token: 0x06008A12 RID: 35346 RVA: 0x00267EF0 File Offset: 0x002660F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06008A13 RID: 35347 RVA: 0x00267F00 File Offset: 0x00266100
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(MonsterInGroupInformation other)
		{
			return true;
		}

		// Token: 0x06008A14 RID: 35348 RVA: 0x00267F10 File Offset: 0x00266110
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06008A15 RID: 35349 RVA: 0x00267F20 File Offset: 0x00266120
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06008A16 RID: 35350 RVA: 0x00267F30 File Offset: 0x00266130
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06008A17 RID: 35351 RVA: 0x00267F40 File Offset: 0x00266140
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06008A18 RID: 35352 RVA: 0x00267F50 File Offset: 0x00266150
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06008A19 RID: 35353 RVA: 0x00267F60 File Offset: 0x00266160
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(MonsterInGroupInformation other)
		{
		}

		// Token: 0x06008A1A RID: 35354 RVA: 0x00267F70 File Offset: 0x00266170
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06008A1B RID: 35355 RVA: 0x00267F80 File Offset: 0x00266180
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06008A1C RID: 35356 RVA: 0x00267F90 File Offset: 0x00266190
		[MethodImpl(MethodImplOptions.NoInlining)]
		static MonsterInGroupInformation()
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
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_33aa8f74862341cc9386ec2586b137b3 == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 2:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_fc95f38c3f7f4096b9c30dd67655cbfd == 0)
					{
						num2 = 1;
						continue;
					}
					continue;
				case 3:
					return;
				case 4:
					MonsterInGroupInformation._parser = new MessageParser<MonsterInGroupInformation>(() => null);
					num2 = 2;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_9977cdd0d7324aea8156198254612854 != 0)
					{
						num2 = 3;
						continue;
					}
					continue;
				}
				UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
				num2 = 4;
			}
		}

		// Token: 0x06008A1D RID: 35357 RVA: 0x00268074 File Offset: 0x00266274
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool CXfdSpJdtqwwKQxnQjIa()
		{
			return true;
		}

		// Token: 0x06008A1E RID: 35358 RVA: 0x0026807C File Offset: 0x0026627C
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static MonsterInGroupInformation KD162JJdwFEAkGFB6GIg()
		{
			return null;
		}

		// Token: 0x040032D7 RID: 13015
		private static readonly MessageParser<MonsterInGroupInformation> _parser;

		// Token: 0x040032D8 RID: 13016
		private UnknownFieldSet _unknownFields;

		// Token: 0x040032D9 RID: 13017
		public const int GidFieldNumber = 1;

		// Token: 0x040032DA RID: 13018
		private int gid_;

		// Token: 0x040032DB RID: 13019
		public const int GradeFieldNumber = 2;

		// Token: 0x040032DC RID: 13020
		private int grade_;

		// Token: 0x040032DD RID: 13021
		public const int LevelFieldNumber = 3;

		// Token: 0x040032DE RID: 13022
		private int level_;

		// Token: 0x040032DF RID: 13023
		public const int LookFieldNumber = 4;

		// Token: 0x040032E0 RID: 13024
		private EntityLook look_;

		// Token: 0x040032E1 RID: 13025
		private static MonsterInGroupInformation NOTZ4qJdDv42kmu23FRS;
	}
}
